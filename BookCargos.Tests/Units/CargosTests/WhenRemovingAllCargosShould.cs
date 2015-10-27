using BookCargos.Model;
using FluentAssertions;
using NUnit.Framework;
using Ploeh.AutoFixture;

namespace BookCargos.Tests.Units.CargosTests
{
    public class WhenRemovingAllCargosShould : CargosFixture
    {
        private readonly Fixture _fixture = new Fixture();

        [Test]
        public void RemoveAllGivenSomePresents()
        {
            var aCargo = ACargo();
            Cargos.Add(aCargo);

            Cargos.RemoveAll();

            Cargos.Contains(aCargo).Should().BeFalse();
        }

        private Cargo ACargo()
        {
            return _fixture.Create<Cargo>();
        }
    }
}