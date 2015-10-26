using System;

namespace BookCargos.Model
{
    public class Vessel
    {
        private Vessel() { }

        public static Vessel CreateEmpty()
        {
            throw new NotImplementedException();
        }

        public bool WillTransport(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public static Vessel CreateFull()
        {
            throw new NotImplementedException();
        }
    }
}
