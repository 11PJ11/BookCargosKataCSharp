using System.Collections.Generic;
using System.Linq;

namespace BookCargos.Model
{
    public class Cargos : ICargos
    {
        private readonly IList<Cargo> _cargos = new List<Cargo>();

        public CubicFeet TotalSizeAdding(Cargo cargo)
        {
            var currentTotalSize = _cargos.Aggregate(CubicFeet.Zero,(acc, c)=> acc + c.Size);
            return currentTotalSize + cargo.Size;
        }

        public void Add(Cargo cargo)
        {
            _cargos.Add(cargo);
        }

        public void RemoveAll()
        {
            _cargos.Clear();
        }

        public bool Contains(Cargo cargo)
        {
            return _cargos.Contains(cargo);
        }
    }
}