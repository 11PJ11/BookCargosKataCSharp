using FluentAssertions;
using NUnit.Framework;

namespace BookCargos.Tests.Units.Model.Booking.VesselTests
{
    public class WhenCheckingWhetherItIsTransportingACargoShould 
        : VesselFixture
    {
        [Test]
        public void ReturnFalseGivenNoCargoHasBeenAdded()
        {
            var aCargo = GetACargo();

            Vessel.IsTransporting(aCargo).Should().BeFalse();
        }
    }
}
