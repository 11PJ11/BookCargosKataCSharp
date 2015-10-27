using BookCargos.Infrastructure.Notification;
using BookCargos.Model;
using NSubstitute;
using NUnit.Framework;
using Ploeh.AutoFixture;

namespace BookCargos.Tests.Units.VesselTests
{
    [TestFixture]
    public class VesselFixture
    {
        protected ICargos Cargos = Substitute.For<ICargos>();
        protected Vessel Vessel;
        protected INotifications Notifications = Substitute.For<INotifications>();
        protected Fixture _fixture = new Fixture();
        protected readonly CubicFeet TWENTY_CUBIC_FEET = new CubicFeet(20);
        protected readonly CubicFeet ONE_THOUSAND_CUBIC_FEET = new CubicFeet(1000);

        protected Vessel CreateAVessel()
        {
            return VesselBuilder
                .AVessel()
                .WithCapacity(ONE_THOUSAND_CUBIC_FEET)
                .Transporting(Cargos)
                .NotifyingWith(Notifications)
                .Build();
        }

        protected Cargo ACargo()
        {
            return Cargo.WithSize(TWENTY_CUBIC_FEET);
        }
    }

    public class WhenAddingCargoVesselShould : VesselFixture
    {
        
        [Test]
        public void AcceptCargoGivenThatItHasEnoughCapacity()
        {
            Vessel = CreateAVessel();

            var aCargo = ACargo();
            Vessel.Add(aCargo);

            Cargos.Received().Add(aCargo);
            Notifications.Received().Send(Arg.Any<BookingConfirmed>());
        }
    }
}
