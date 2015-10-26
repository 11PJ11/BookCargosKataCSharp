namespace BookCargos.Infrastructure.Notification
{
    public interface INotifications
    {
        void Send(Notification notification);
    }
}