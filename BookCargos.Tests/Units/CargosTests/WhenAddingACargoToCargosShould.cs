using BookCargos.Model;
using FluentAssertions;
using NUnit.Framework;

namespace BookCargos.Tests.Units.CargosTests
{
    public class WhenAddingACargoToCargosShould: CargosFixture
    {

        [Test]
        public void ContainTheCargoGivenTheCargoWasAdded()
        {
            var cargo = Cargo.WithSize(new CubicFeet(100));

            Cargos.Add(cargo);

            Cargos.Contains(cargo).Should().BeTrue();
        }

        [Test]
        public void NotContainTheCargoGivenTheCargoWasNotAdded()
        {
            var cargo = Cargo.WithSize(new CubicFeet(100));

            Cargos.Contains(cargo).Should().BeFalse();
        }
    }
}