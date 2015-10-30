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
        private ICargo _cargo;
        private Container _container;
        private readonly INotify _notifier = Substitute.For<INotify>();

        [Given(@"a vessel with (.*) cubic feet capacity")]
        public void GivenAVesselWithCubicFeetCapacity(int capacity)
        {
            _cargo = new Cargo();
            _vessel = new Vessel(capacity.CubicFeet(), _cargo);
        }

        [Given(@"a Container of (.*) cubic feet in size")]
        public void GivenAContainerOfCubicFeetInSize(int size)
        {
            _container = new Container(size.CubicFeet());
        }

        [Given(@"the vessel has been booked for a total of (.*) cubic feet")]
        public void GivenTheVesselHasBeenBookedForATotalOfCubicFeet(int bookedCapacity)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I book the Container on the vessel")]
        public void WhenIBookTheContainerOnTheVessel()
        {
            var bookingContainersOnVessel = new BookingContainersOnVessel(_vessel, _container);
            bookingContainersOnVessel.Execute();
        }

        [Then(@"the vessel will transport the Container")]
        public void ThenTheVesselWillTransportTheContainer()
        {
            _vessel.IsTransporting(_container).Should().BeTrue();
        }

        [Then(@"I received a booking confirmation with a number")]
        public void ThenIReceivedABookingConfirmationWithANumber()
        {
            var bookingId = new BookingId(1234);
            _notifier.Received().Send(new BookingConfirmed(bookingId));
        }

        [Then(@"the vessel doesn't accept the Container")]
        public void ThenTheVesselDoesNotAcceptTheContainer()
        {
            _vessel.IsTransporting(_container).Should().BeFalse();
        }
        
        [Then(@"I received a notification for missing capacity on the vessel")]
        public void ThenIReceivedANotificationForMissingCapacityOnTheVessel()
        {
            _notifier.Received().Send(new MissingCapacityOnVessel());
        }
    }
}
