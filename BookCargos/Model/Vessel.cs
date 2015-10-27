using System;

namespace BookCargos.Model
{
    public class Vessel
    {
        private readonly ICargos _cargos;
        private readonly CubicFeet _capacity;

        private Vessel() { }

        public Vessel(ICargos cargos, CubicFeet capacity)
        {
            _cargos = cargos;
            _capacity = capacity;
        }

        public bool WillTransport(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public void RemoveAllCargos()
        {
            _cargos.RemoveAll();
        }
    }
}
