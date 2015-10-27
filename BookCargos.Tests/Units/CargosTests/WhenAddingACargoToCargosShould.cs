using BookCargos.Model;
using FluentAssertions;
using NUnit.Framework;

namespace BookCargos.Tests.Units.CargosTests
{
    public class WhenAddingACargoToCargosShould: CargosFixture
    {

        [Test]
        public void ContainTheCargo()
        {
            var cargo = Cargo.WithSize(new CubicFeet(100));

            Cargos.Add(cargo);

            Cargos.Contains(cargo).Should().BeTrue();
        }
    }
}