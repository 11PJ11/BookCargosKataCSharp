namespace BookCargos.Model
{
    public interface ICargos
    {
        CubicFeet TotalSizeAdding(Cargo cargo);
        void Add(Cargo cargo);
        void RemoveAll();
        bool Contains(Cargo cargo);
    }
}