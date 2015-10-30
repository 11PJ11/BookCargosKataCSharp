namespace BookCargos.Model.Booking
{
    public interface ITransportCargos
    {
        bool IsTransporting(Container container);
        void Transport(Container container);
    }
}