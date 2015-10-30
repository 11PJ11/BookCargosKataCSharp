using System.Collections.Generic;
using System.Linq;

namespace BookCargos.Model.Booking
{
    public class Cargo : ICargo
    {
        private readonly Stack<Container> _containers = new Stack<Container>();

        public void Load(Container container)
        {
            _containers.Push(container);
        }

        public Container UnloadLast()
        {
            return _containers.Pop();
        }

        protected bool Equals(Cargo otherCargo)
        {
            return CargosHaveSameNumberOfContainers(otherCargo) &&
                   CargosHaveTheSameContainers(otherCargo);
        }

        public override bool Equals(object other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            if (other.GetType() != this.GetType()) return false;
            return Equals((Cargo)other);
        }

        public override int GetHashCode()
        {
            return (_containers != null ? _containers.GetHashCode() : 0);
        }

        private bool CargosHaveTheSameContainers(Cargo otherCargo)
        {
            return _containers
                .All(container => otherCargo._containers.Contains(container));
        }

        private bool CargosHaveSameNumberOfContainers(Cargo other)
        {
            return _containers.Count == other._containers.Count;
        }
    }
}