using BookCargos.Model;
using FluentAssertions;
using NUnit.Framework;

namespace BookCargos.Tests.Units.CargosTests
{
    public class WhenCalculatingTotalSizeAddingACargoShould : CargosFixture
    {
        private CubicFeet TWO_HUNDRED_CUBIC_FEET = new CubicFeet(200);
        private CubicFeet HUNDRED_CUBIC_FEET = new CubicFeet(100);
        private CubicFeet ZERO_CUBIC_FEET = new CubicFeet(0);

        [Test]
        public void ReturnTheSizeOfTheCargoGivenTheCargosIsEmpty()
        {
            Cargos.TotalSizeAdding(Cargo.WithSize(HUNDRED_CUBIC_FEET))
                .Should().Be(HUNDRED_CUBIC_FEET);
        }

        [Test]
        public void ReturnTheTotalSizeOfTheCargosPlusTheSizeOfTheAddedCargoInCubicFeetGivenSomeCargosWereAdded()
        {
            Cargos.RemoveAll();
            Cargos.Add(Cargo.WithSize(HUNDRED_CUBIC_FEET));
            var cargoToAdd = Cargo.WithSize(HUNDRED_CUBIC_FEET);
            
            var totalSize = Cargos.TotalSizeAdding(cargoToAdd);

            totalSize.Should().Be(TWO_HUNDRED_CUBIC_FEET);
        }
}
}