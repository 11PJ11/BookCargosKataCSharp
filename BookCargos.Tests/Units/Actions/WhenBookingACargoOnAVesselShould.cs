using BookCargos.Actions;
using BookCargos.Model.Booking;
using NSubstitute;
using NUnit.Framework;

namespace BookCargos.Tests.Units.Actions
{
    public class WhenBookingACargoOnAVesselShould
    {
        private BookingCargoOnVessel _bookingAction;
        private readonly ITransportCargos _vessel = Substitute.For<ITransportCargos>();

        [SetUp]
        public void Init()
        {
            var aCargo = new Cargo(10.CubicFeet());
            _bookingAction = new BookingCargoOnVessel(_vessel, aCargo);
        }

        [Test]
        public void AddTheCargoToTheVessel()
        {
            _bookingAction.Execute();

            _vessel.Received().Transport(Arg.Any<Cargo>());
        }
    }
}
