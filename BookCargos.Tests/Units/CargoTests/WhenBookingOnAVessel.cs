using BookCargos.Model;
using NSubstitute;
using NUnit.Framework;

namespace BookCargos.Tests.Units.CargoTests
{
    public class WhenBookingOnAVessel
        : CargoFixture
    {
        protected readonly ICargos _cargos = Substitute.For<ICargos>();
        
        protected readonly CubicFeet TWENTY_CUBIC_FEET = new CubicFeet(20);
        protected readonly CubicFeet ONE_THOUSAND_CUBIC_FEET = new CubicFeet(1000);

        [Test]
        public void GivenVesselHasCapacity()
        {
            var aVessel = CreateAVessel();
            var cargo = Cargo.WithSize(TWENTY_CUBIC_FEET);
            _cargos.TotalSize().Returns(new CubicFeet(900));

            cargo.BookOn(aVessel);

            _cargos.Received().Add(cargo);
        }

        [Test]
        public void GivenVesselHasNoCapacity()
        {
            var aVessel = CreateAVessel();
            var cargo = Cargo.WithSize(TWENTY_CUBIC_FEET);
            _cargos.TotalSize().Returns(new CubicFeet(990));

            cargo.BookOn(aVessel);

            _cargos.DidNotReceive().Add(cargo);
        }

        protected Vessel CreateAVessel()
        {
            return VesselBuilder.AVessel()
                .WithCapacity(ONE_THOUSAND_CUBIC_FEET)
                .Transporting(_cargos)
                .Build();
        }
    }
}