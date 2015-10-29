namespace BookCargos.Model.Booking
{
    public class Vessel : ITransportCargos
    {
        public Vessel(CubicFeet capacity)
        {
        }

        public bool IsTransporting(Cargo cargo)
        {
            return false;
        }

        public void Transport(Cargo cargo)
        {
        }
    }
}
