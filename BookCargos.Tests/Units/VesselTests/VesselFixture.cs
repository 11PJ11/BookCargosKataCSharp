using BookCargos.Model;
using NSubstitute;
using NUnit.Framework;

namespace BookCargos.Tests.Units.VesselTests
{
    [TestFixture]
    public class VesselFixture
    {
        protected ICargos Cargos = Substitute.For<ICargos>();
        protected Vessel Vessel;

        protected Vessel CreateAVessel()
        {
            return VesselBuilder
                .AVessel()
                .WithCapacity(new CubicFeet(1000))
                .Transporting(Cargos)
                .Build();
        }
    }
}
