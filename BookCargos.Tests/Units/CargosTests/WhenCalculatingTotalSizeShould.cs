using BookCargos.Model;
using FluentAssertions;
using NUnit.Framework;

namespace BookCargos.Tests.Units.CargosTests
{
    public class WhenCalculatingTotalSizeShould : CargosFixture
    {
        private CubicFeet TWO_HUNDRED_CUBIC_FEET = new CubicFeet(200);
        private CubicFeet HUNDRED_CUBIC_FEET = new CubicFeet(100);
        private CubicFeet ZERO_CUBIC_FEET = new CubicFeet(0);

        [Test]
        public void ReturnZeroCubicFeetGivenTheCargosIsEmpty()
        {
            Cargos.TotalSize().Should().Be(ZERO_CUBIC_FEET);
        }

        //[Test]
        //public void ReturnTheTotalSizeOfTheCargosInCubicFeetGivenSomeCargoWereAdded()
        //{
        //    Cargos.RemoveAll();
        //    Cargos.Add(Cargo.WithSize(HUNDRED_CUBIC_FEET));
        //    Cargos.Add(Cargo.WithSize(HUNDRED_CUBIC_FEET));

        //    var totalSize = Cargos.TotalSize();

        //    totalSize.Should().Be(TWO_HUNDRED_CUBIC_FEET);
        //}
}
}