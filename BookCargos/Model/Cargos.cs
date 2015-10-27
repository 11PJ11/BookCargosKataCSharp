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
            throw new System.NotImplementedException();
        }

        public void RemoveAll()
        {
            throw new System.NotImplementedException();
        }
    }
}