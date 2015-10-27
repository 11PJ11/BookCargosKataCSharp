using BookCargos.Model;
using FluentAssertions;
using NUnit.Framework;

namespace BookCargos.Tests.Units.CargosTests
{
    public class WhenCalculatingTotalSizeShould : CargosFixture
    {
        [Test]
        public void ReturnZeroCubicFeetGivenTheCargosIsEmpty()
        {
            Cargos.TotalSize().Should().Be(new CubicFeet(0));
        }

        [Test]
        public void ReturnTheSizeOfOneCargoInCubicFeetGivenOneCargoWasAdded()
        {
            Cargos.RemoveAll();

            Cargos.Add(Cargo.WithSize(new CubicFeet(100)));

            Cargos.TotalSize().Should().Be(new CubicFeet(100));
        }
}
}