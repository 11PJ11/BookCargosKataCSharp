using BookCargos.Infrastructure.Notification;
using BookCargos.Model;
using NSubstitute;

namespace BookCargos.Tests.Specs.Steps.BookingACargo
{
    public class WhenBookingACargo
    {
        protected Vessel Vessel;
        protected Cargo Cargo;
        protected INotifications Notifications = 
            Substitute.For<INotifications>();

        protected readonly ICargos _cargos = Substitute.For<ICargos>();
    }
}