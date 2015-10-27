using BookCargos.Infrastructure.Notification;
using BookCargos.Model;
using FluentAssertions;
using NSubstitute;
using TechTalk.SpecFlow;

namespace BookCargos.Tests.Specs.Steps.BookingACargo
{
    [Binding]
    public class BookingACargoSteps
    {
        protected Vessel Vessel;
        protected Cargo Cargo;
        protected INotifications Notifications =
            Substitute.For<INotifications>();

        protected readonly ICargos Cargos = new Cargos();

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
                .Transporting(Cargos)
                .Build();
        }

        [Given(@"the vessel is empty")]
        public void GivenTheVesselIsEmpty()
        {
            Vessel.RemoveAllCargos();
        }

        [When(@"I book a cargo of (.*) cubic feet")]
        public void WhenIBookACargoOfCubicFeet(int cargoSize)
        {
            Cargo = Cargo.WithSize(new CubicFeet(cargoSize));
            Cargo.BooksOn(Vessel);
        }

        [Then(@"the cargo is added to the vessel")]
        public void ThenTheCargoIsAddedToTheVessel()
        {
            Vessel.IsTransporting(Cargo).Should().BeTrue();
        }
        
        [Then(@"I receive a booking confirmation")]
        public void ThenIReceiveABookingConfirmation()
        {
            Notifications.Received().Send(Arg.Any<BookingConfirmed>());
        }
    }
}
