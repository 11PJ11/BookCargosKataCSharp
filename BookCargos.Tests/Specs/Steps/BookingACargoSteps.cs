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

        [Given(@"a vessel with enough capacity left")]
        public void GivenAVesselWithEnoughCapacityLeft()
        {
            _vessel = Vessel.CreateEmpty();
        }

        [Given(@"a full vessel without enough capacity left")]
        public void GivenAFullVesselWithoutEnoughCapacityLeft()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I book a cargo")]
        public void WhenIBookACargo()
        {
            _cargo = new Cargo();
            _cargo.BookOn(_vessel);
        }

        [Then(@"the cargo is added to the vessel")]
        public void ThenTheCargoIsAddedToTheVessel()
        {
            _vessel.WillTransport(_cargo).Should().BeTrue();
        }
        
        [Then(@"I receive a booking confirmation")]
        public void ThenIReceiveABookingConfirmation()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the cargo is not added to the vessel")]
        public void ThenTheCargoIsNotAddedToTheVessel()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I receive a notification that the vessel has not capacity")]
        public void ThenIReceiveANotificationThatTheVesselHasNotCapacity()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
