using NSubstitute;
using NUnit.Framework;

namespace BookCargos.Tests.Units.VesselTests
{
    public class WhenClearingTheVesselShould
        : VesselFixture
    {
        
        [Test]
        public void RemoveAllTheCargos()
        {
            Vessel = CreateAVessel();

            Vessel.Clear();

            Cargos.Received().RemoveAll();
        }
    }
}