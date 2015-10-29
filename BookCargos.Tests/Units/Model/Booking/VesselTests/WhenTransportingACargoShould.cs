using BookCargos.Model.Booking;
using NSubstitute;
using NUnit.Framework;

namespace BookCargos.Tests.Units.Model.Booking.VesselTests
{
    public class WhenTransportingACargoShould 
        : VesselFixture
    {
        [Test]
        public void StoreTheCargo()
        {
            var aCargo = GetACargo();
            
            Vessel.Transport(aCargo);

            TransportedCargos.Received().Add(Arg.Any<Cargo>());
        }
    }
}