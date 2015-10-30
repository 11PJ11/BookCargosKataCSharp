using BookCargos.Model.Booking;
using FluentAssertions;
using NUnit.Framework;
using Ploeh.AutoFixture;

namespace BookCargos.Tests.Units.Model.Booking.CargosTests
{
    public class WhenLoadingAContainerIntoACargoShould
    {
        private readonly Fixture _fixture = new Fixture();

        [Test]
        public void ReturnTheLoadedContainerWhenUnloadingTheLastLoaded()
        {
            var containerToLoad = _fixture.Create<Container>();
            var cargo = new Cargo();

            cargo.Load(containerToLoad);
            var unloaded = cargo.UnloadLast();

            unloaded.Should().Be(containerToLoad);
        }

        [Test]
        public void ContainTheCargoGivenWasLoaded()
        {
            var anotherCargo = new Cargo();
            var cargo = new Cargo();
            var containerToLoad = _fixture.Create<Container>();
            anotherCargo.Load(containerToLoad);

            cargo.Load(containerToLoad);

            cargo.Should().Be(anotherCargo);
        }

        [Test]
        public void NotContainTheCargoGivenWasNotLoaded()
        {
            var anotherCargo = new Cargo();
            var cargo = new Cargo();
            var containerToLoad = _fixture.Create<Container>();

            anotherCargo.Load(containerToLoad);

            cargo.Should().NotBe(anotherCargo);
        }
    }
}
