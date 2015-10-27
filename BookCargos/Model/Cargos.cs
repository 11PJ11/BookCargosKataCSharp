namespace BookCargos.Model
{
    public class Cargos : ICargos
    {

        public CubicFeet TotalSize()
        {
            return new CubicFeet(0);
        }

        public void Add(Cargo cargo)
        {
        }

        public void RemoveAll()
        {
            
        }

        public bool Contains(Cargo cargo)
        {
            return true;
        }
    }
}