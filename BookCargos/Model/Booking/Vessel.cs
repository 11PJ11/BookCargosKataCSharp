namespace BookCargos.Model.Booking
{
    public class Vessel : ITransportCargo
    {
        private readonly ICargo _transportedCargo;

        public Vessel(CubicFeet capacity, ICargo transportedCargo)
        {
            _transportedCargo = transportedCargo;
        }

        public bool IsTransporting(Container container)
        {
            return false;
        }

        public void Transport(Container container)
        {
            _transportedCargo.Load(container);
        }
    }
}
