namespace BookCargos.Model
{
    public class Vessel
    {
        public Vessel(CubicFeet capacity)
        {
        }

        public bool IsTransporting(Cargo cargo)
        {
            return false;
        }
    }
}
