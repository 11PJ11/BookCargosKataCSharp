using BookCargos.Infrastructure.Notification;
using BookCargos.Model;
using NSubstitute;
using NUnit.Framework;

namespace BookCargos.Tests.Units.VesselTests
{
    public class WhenAddingCargoVesselShould : VesselFixture
    {
        [Test]
        public void AcceptCargoGivenThatItHasEnoughCapacity()
        {
            var aCargo = Cargo.WithSize(TWENTY_CUBIC_FEET);
            Cargos.TotalSizeAdding(aCargo)
                .Returns(new CubicFeet(980));

            Vessel.Add(aCargo);

            Cargos.Received().Add(aCargo);
            Notifications.Received().Send(Arg.Any<BookingConfirmed>());
        }

        [Test]
        public void RejectCargoGivenThereIsNotEnouhgCapacity()
        {
            var aCargo = Cargo.WithSize(TWENTY_CUBIC_FEET);
            Cargos.TotalSizeAdding(aCargo)
                .Returns(new CubicFeet(5020));

            Vessel.Add(aCargo);

            Cargos.DidNotReceive().Add(aCargo);
            Notifications.Received().Send(Arg.Any<NoCapacityBookingRejected>());
        }
    }
}