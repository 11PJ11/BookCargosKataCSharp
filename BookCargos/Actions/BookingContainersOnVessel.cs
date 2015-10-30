using BookCargos.Model.Booking;

namespace BookCargos.Actions
{
    public class BookingContainersOnVessel
    {
        private readonly ITransportCargos _vessel;
        private readonly Container _container;

        public BookingContainersOnVessel(ITransportCargos vessel, Container container)
        {
            _vessel = vessel;
            _container = container;
        }

        public void Execute()
        {
            _vessel.Transport(_container);
        }
    }
}
