namespace BookCargos.Model.Notification
{
    public interface INotify
    {
        void Send(Infrastructure.Notification.Notification notification);
    }
}