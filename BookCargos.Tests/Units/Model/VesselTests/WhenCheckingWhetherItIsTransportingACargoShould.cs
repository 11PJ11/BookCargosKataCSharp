using BookCargos.Model;
using FluentAssertions;
using NUnit.Framework;

namespace BookCargos.Tests.Units.Model.VesselTests
{
    [TestFixture]
    public class WhenCheckingWhetherItIsTransportingACargoShould
    {
        [Test]
        public void ReturnFalseGivenNoCargoHasBeenAdded()
        {
            var vessel = new Vessel(1000.InCubicFeet());
            var aCargo = new Cargo(20.InCubicFeet());

            vessel.IsTransporting(aCargo).Should().BeFalse();
        }
    }
}
