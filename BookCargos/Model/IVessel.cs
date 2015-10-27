namespace BookCargos.Model
{
    public interface IVessel
    {
        bool IsTransporting(Cargo cargo);
        void RemoveAllCargos();
        void Add(Cargo cargo);
    }
}