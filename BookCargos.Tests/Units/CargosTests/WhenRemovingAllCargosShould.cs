using BookCargos.Model;
using FluentAssertions;
using NUnit.Framework;

namespace BookCargos.Tests.Units.CargosTests
{
    public class WhenRemovingAllCargosShould : CargosFixture
    {
        private CubicFeet ZERO_CUBIC_FEET = new CubicFeet(0);

        [Test]
        public void RemoveAll()
        {
            Cargos.RemoveAll();

            Cargos.TotalSize().Should().Be(ZERO_CUBIC_FEET);
        }
    }
}