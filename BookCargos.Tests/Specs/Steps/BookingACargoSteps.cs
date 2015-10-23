using TechTalk.SpecFlow;

namespace BookCargos.Tests.Specs.Steps
{
    [Binding]
    public class BookingACargoSteps
    {
        [Given(@"a vessel with enough capacity left")]
        public void GivenAVesselWithEnoughCapacityLeft()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"a full vessel without enough capacity left")]
        public void GivenAFullVesselWithoutEnoughCapacityLeft()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I book a cargo")]
        public void WhenIBookACargo()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the cargo is added to the vessel")]
        public void ThenTheCargoIsAddedToTheVessel()
        {
            ScenarioContext.Current.Pending();
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
