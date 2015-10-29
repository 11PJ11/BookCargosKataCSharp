namespace BookCargos.Model.Booking
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
