using BookCargos.Model;
using FluentAssertions;
using NUnit.Framework;

namespace BookCargos.Tests.Units.CargosTests
{
    [TestFixture]
    public class CargosFixture
    {
        protected Cargos Cargos = new Cargos();
    }

    public class WhenRemovingAllCargosShould : CargosFixture
    {
        [Test]
        public void RemoveAll()
        {
            Cargos.RemoveAll();

            Assert.That(Cargos.TotalSize(), Is.EqualTo(new CubicFeet(0)));
        }
    }

    public class WhenCalculatingTotalSizeShould : CargosFixture
    {
        [Test]
        public void ReturnZeroCubicFeetGivenTheCargosIsEmpty()
        {

            Cargos.TotalSize().Should().Be(new CubicFeet(0));
        }
    }
}
