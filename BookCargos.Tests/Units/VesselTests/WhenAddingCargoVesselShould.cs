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
            var aCargo = ACargo();
            
            Vessel.Add(aCargo);

            Cargos.Received().Add(aCargo);
            Notifications.Received().Send(Arg.Any<BookingConfirmed>());
        }

        [Test]
        public void RejectCargoGivenThereIsNotEnouhgCapacity()
        {
            var aCargo = Cargo.WithSize(new CubicFeet(2000));

            Vessel.Add(aCargo);

            Cargos.DidNotReceive().Add(aCargo);
            Notifications.Received().Send(Arg.Any<NoCapacityBookingRejected>());
        }
    }
}