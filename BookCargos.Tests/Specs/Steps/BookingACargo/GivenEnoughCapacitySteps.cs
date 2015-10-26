using BookCargos.Infrastructure.Notification;
using BookCargos.Model;
using FluentAssertions;
using NSubstitute;
using TechTalk.SpecFlow;

namespace BookCargos.Tests.Specs.Steps.BookingACargo
{
    [Binding]
    public class GivenEnoughCapacitySteps
        : WhenBookingACargo
    {
        [BeforeScenario]
        public void Setup()
        {
            Notifications = new Notifications();
        }

        [Given(@"a vessel with enough capacity left")]
        public void GivenAVesselWithEnoughCapacityLeft()
        {
            Vessel = Vessel.CreateEmpty();
        }
        
        [When(@"I book a cargo")]
        public void WhenIBookACargo()
        {
            Cargo = new Cargo();
            Cargo.BookOn(Vessel);
        }

        [Then(@"the cargo is added to the vessel")]
        public void ThenTheCargoIsAddedToTheVessel()
        {
            Vessel.WillTransport(Cargo).Should().BeTrue();
        }
        
        [Then(@"I receive a booking confirmation")]
        public void ThenIReceiveABookingConfirmation()
        {
            Notifications.Received().Send(Arg.Any<BookingConfirmed>());
        }
    }
}
