using System.ComponentModel;
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

        [Given(@"a vessel with (.*) cubic feet capacity")]
        public void GivenAVesselWithCubicFeetCapacity(int capacity)
        {
            Vessel = VesselBuilder.AVessel()
                .WithCapacity(new CubicFeet(capacity))
                .Transporting(_cargos)
                .Build();
        }

        [Given(@"the vessel is empty")]
        public void GivenTheVesselIsEmpty()
        {
            Vessel.Clear();
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
