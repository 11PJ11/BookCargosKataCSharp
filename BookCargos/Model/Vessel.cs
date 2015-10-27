using BookCargos.Infrastructure.Notification;

namespace BookCargos.Model
{
    public class Vessel : IVessel
    {
        private readonly INotifications _notifications;
        private readonly ICargos _cargos;
        private readonly CubicFeet _capacity;

        private Vessel() { }

        public Vessel(INotifications notifications, ICargos cargos, CubicFeet capacity)
        {
            _notifications = notifications;
            _cargos = cargos;
            _capacity = capacity;
        }

        public void RemoveAllCargos()
        {
            _cargos.RemoveAll();
        }

        public void Add(Cargo cargo)
        {
            Notification notification;
            if (_capacity >= _cargos.TotalSizeAdding(cargo))
            {
                _cargos.Add(cargo);
                notification = new BookingConfirmed();
            }
            else
            {
                notification = new NoCapacityBookingRejected();
            }

            _notifications.Send(notification);
        }
    }
}
