using BookCargos.Actions;
using BookCargos.Model.Booking;
using NSubstitute;
using NUnit.Framework;

namespace BookCargos.Tests.Units.Actions
{
    public class WhenBookingACargoOnAVesselShould
    {
        private BookingContainersOnVessel _bookingAction;
        private readonly ITransportCargos _vessel = Substitute.For<ITransportCargos>();

        [SetUp]
        public void Init()
        {
            var aCargo = new Container(10.CubicFeet());
            _bookingAction = new BookingContainersOnVessel(_vessel, aCargo);
        }

        [Test]
        public void AddTheCargoToTheVessel()
        {
            _bookingAction.Execute();

            _vessel.Received().Transport(Arg.Any<Container>());
        }
    }
}
