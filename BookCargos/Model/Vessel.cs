using System;

namespace BookCargos.Model
{
    public class Vessel : IVessel
    {
        private readonly ICargos _cargos;
        private readonly CubicFeet _capacity;

        private Vessel() { }

        public Vessel(ICargos cargos, CubicFeet capacity)
        {
            _cargos = cargos;
            _capacity = capacity;
        }

        public bool IsTransporting(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public void RemoveAllCargos()
        {
            _cargos.RemoveAll();
        }

        public void Add(Cargo cargo)
        {
            throw new NotImplementedException();
        }
    }
}
