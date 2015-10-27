using BookCargos.Model;
using NSubstitute;
using NUnit.Framework;

namespace BookCargos.Tests.Units.CargoTests
{
    public class WhenBookingOnAVesselShould
        : CargoFixture
    {
        protected readonly CubicFeet TWENTY_CUBIC_FEET = new CubicFeet(20);
        protected readonly CubicFeet ONE_THOUSAND_CUBIC_FEET = new CubicFeet(1000);

        [Test]
        public void AddACargo()
        {
            var aVessel = CreateAVessel();
            var cargo = Cargo.WithSize(TWENTY_CUBIC_FEET);
           
            cargo.BooksOn(aVessel);

            aVessel.Received().Add(cargo);
        }

        protected IVessel CreateAVessel()
        {
            return Substitute.For<IVessel>();
        }
    }
}