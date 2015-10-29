namespace BookCargos.Model.Booking
{
    public interface ITransportCargos
    {
        bool IsTransporting(Cargo cargo);
        void Transport(Cargo cargo);
    }
}