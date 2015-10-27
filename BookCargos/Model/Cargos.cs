using System.Collections.Generic;

namespace BookCargos.Model
{
    public class Cargos : ICargos
    {
        private readonly IList<Cargo> _cargos = new List<Cargo>();

        public CubicFeet TotalSize()
        {
            return new CubicFeet(0);
        }

        public void Add(Cargo cargo)
        {
            _cargos.Add(cargo);
        }

        public void RemoveAll()
        {
            
        }

        public bool Contains(Cargo cargo)
        {
            return _cargos.Contains(cargo);
        }
    }
}