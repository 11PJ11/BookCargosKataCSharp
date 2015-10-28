using System;
using TechTalk.SpecFlow;

namespace BookCargos.Tests.Specs.Steps
{
    [Binding]
    public class BookingACargoSteps
    {
        [Given(@"a vessel with (.*) cubic feet capacity")]
        public void GivenAVesselWithCubicFeetCapacity(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the vessel has (.*) cubic feet capacity left")]
        public void GivenTheVesselHasCubicFeetCapacityLeft(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"a cargo of (.*) cubic feet in size")]
        public void GivenACargoOfCubicFeetInSize(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I book the cargo on the vessel")]
        public void WhenIBookTheCargoOnTheVessel()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the vessel doesn't accept the cargo")]
        public void ThenTheVesselDoesnTAcceptTheCargo()
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
