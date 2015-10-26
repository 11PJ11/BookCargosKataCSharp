using BookCargos.Infrastructure.Notification;
using BookCargos.Model;
using FluentAssertions;
using NSubstitute;
using TechTalk.SpecFlow;

namespace BookCargos.Tests.Specs.Steps.BookingACargo
{

    [Binding]
    public class GivenNotEnoughCapacity 
        : WhenBookingACargo
    {
        [Given(@"a full vessel without enough capacity left")]
        public void GivenAFullVesselWithoutEnoughCapacityLeft()
        {
            Vessel = Vessel.CreateFull();
        }

        [Then(@"the cargo is not added to the vessel")]
        public void ThenTheCargoIsNotAddedToTheVessel()
        {
            Vessel.WillTransport(Cargo).Should().BeFalse();
        }

        [Then(@"I receive a notification that the vessel has not capacity")]
        public void ThenIReceiveANotificationThatTheVesselHasNotCapacity()
        {
            Notifications.Received().Send(Arg.Any<NoCapacityBookingRejected>());
        }
    }
}