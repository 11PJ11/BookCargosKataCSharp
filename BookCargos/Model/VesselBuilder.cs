namespace BookCargos.Model
{
    public class VesselBuilder
    {
        private static CubicFeet _cubicFeet = new CubicFeet(0);
        private static ICargos _cargos = new Cargos();

        public static VesselBuilder AVessel()
        {
            return new VesselBuilder();
        }

        public VesselBuilder WithCapacity(CubicFeet capacity)
        {
            _cubicFeet = capacity;
            return this;
        }

        public VesselBuilder Transporting(ICargos cargos)
        {
            _cargos = cargos;
            return this;
        }

        public Vessel Build()
        {
            return new Vessel(_cargos, _cubicFeet);
        }

    }
}