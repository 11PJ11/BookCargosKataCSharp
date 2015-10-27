namespace BookCargos.Model
{
    public interface IVessel
    {
        void RemoveAllCargos();
        void Add(Cargo cargo);
    }
}