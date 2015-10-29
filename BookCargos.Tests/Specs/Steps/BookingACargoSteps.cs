using BookCargos.Actions;
using BookCargos.Model;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace BookCargos.Tests.Specs.Steps
{
    [Binding]
    public class BookingACargoSteps
    {
        private Vessel _vessel;
        private Cargo _cargo;

        [Given(@"a vessel with (.*) cubic feet capacity")]
        public void GivenAVesselWithCubicFeetCapacity(int capacity)
        {
            _vessel = new Vessel(capacity.InCubicFeet());
        }

        [Given(@"a cargo of (.*) cubic feet in size")]
        public void GivenACargoOfCubicFeetInSize(int cargoSize)
        {
            _cargo = new Cargo(cargoSize.InCubicFeet());
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
            ScenarioContext.Current.Pending();
        }

        [Then(@"the vessel doesn't accept the cargo")]
        public void ThenTheVesselDoesNotAcceptTheCargo()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I received a notification for missing capacity on the vessel")]
        public void ThenIReceivedANotificationForMissingCapacityOnTheVessel()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
