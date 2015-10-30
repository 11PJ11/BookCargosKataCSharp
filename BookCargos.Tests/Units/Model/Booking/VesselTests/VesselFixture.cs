using BookCargos.Model.Booking;
using NSubstitute;
using NUnit.Framework;
using Ploeh.AutoFixture;

namespace BookCargos.Tests.Units.Model.Booking.VesselTests
{
    [TestFixture]
    public class VesselFixture
    {
        protected Vessel Vessel;
        protected Fixture Fixture = new Fixture();
        protected ICargo TransportedCargo = Substitute.For<ICargo>();

        [SetUp]
        public void Init()
        {
            Vessel = new Vessel(1000.CubicFeet(), TransportedCargo);
        }

        protected Container GetACargo()
        {
            return Fixture.Create<Container>();
        }
    }
}