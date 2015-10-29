using BookCargos.Model.Booking;

namespace BookCargos.Actions
{
    public class BookingCargoOnVessel
    {
        private readonly ITransportCargos _vessel;
        private readonly Cargo _cargo;

        public BookingCargoOnVessel(ITransportCargos vessel, Cargo cargo)
        {
            _vessel = vessel;
            _cargo = cargo;
        }

        public void Execute()
        {
            _vessel.Transport(_cargo);
        }
    }
}
