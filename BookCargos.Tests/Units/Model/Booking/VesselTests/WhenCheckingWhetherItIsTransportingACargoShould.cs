using BookCargos.Model.Booking;
using FluentAssertions;
using NUnit.Framework;

namespace BookCargos.Tests.Units.Model.Booking.VesselTests
{
    [TestFixture]
    public class WhenCheckingWhetherItIsTransportingACargoShould
    {
        [Test]
        public void ReturnFalseGivenNoCargoHasBeenAdded()
        {
            var vessel = new Vessel(1000.CubicFeet());
            var aCargo = new Cargo(20.CubicFeet());

            vessel.IsTransporting(aCargo).Should().BeFalse();
        }
    }
}
