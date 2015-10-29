using BookCargos.Model.Booking;
using NSubstitute;
using NUnit.Framework;

namespace BookCargos.Tests.Units.Model.Booking.VesselTests
{
    [TestFixture]
    public class VesselFixture
    {
        protected Vessel Vessel = new Vessel(1000.CubicFeet());
        protected ICargos TransportedCargos = Substitute.For<ICargos>();

        protected static Cargo GetACargo()
        {
            return new Cargo(20.CubicFeet());
        }
    }
}