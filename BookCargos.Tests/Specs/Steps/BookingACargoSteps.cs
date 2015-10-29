using BookCargos.Actions;
using BookCargos.Infrastructure.Notification;
using BookCargos.Model.Booking;
using BookCargos.Model.Notification;
using FluentAssertions;
using NSubstitute;
using TechTalk.SpecFlow;

namespace BookCargos.Tests.Specs.Steps
{
    [Binding]
    public class BookingACargoSteps
    {
        private Vessel _vessel;
        private Cargo _cargo;
        private readonly INotify _notifier = Substitute.For<INotify>();

        [Given(@"a vessel with (.*) cubic feet capacity")]
        public void GivenAVesselWithCubicFeetCapacity(int capacity)
        {
            _vessel = new Vessel(capacity.CubicFeet());
        }

        [Given(@"a cargo of (.*) cubic feet in size")]
        public void GivenACargoOfCubicFeetInSize(int cargoSize)
        {
            _cargo = new Cargo(cargoSize.CubicFeet());
        }

        [Given(@"the vessel has been booked for a total of (.*) cubic feet")]
        public void GivenTheVesselHasBeenBookedForATotalOfCubicFeet(int bookedCapacity)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I book the cargo on the vessel")]
        public void WhenIBookTheCargoOnTheVessel()
        {
            var bookingOfACargo = new BookingOfACargo();
        }

        [Then(@"the vessel will transport the cargo")]
        public void ThenTheVesselWillTransportTheCargo()
        {
            _vessel.IsTransporting(_cargo).Should().BeTrue();
        }

        [Then(@"I received a booking confirmation with a number")]
        public void ThenIReceivedABookingConfirmationWithANumber()
        {
            var bookingId = new BookingId(1234);
            _notifier.Received().Send(new BookingConfirmed(bookingId));
        }

        [Then(@"the vessel doesn't accept the cargo")]
        public void ThenTheVesselDoesNotAcceptTheCargo()
        {
            _vessel.IsTransporting(_cargo).Should().BeFalse();
        }
        
        [Then(@"I received a notification for missing capacity on the vessel")]
        public void ThenIReceivedANotificationForMissingCapacityOnTheVessel()
        {
            _notifier.Received().Send(new MissingCapacityOnVessel());
        }
    }
}
