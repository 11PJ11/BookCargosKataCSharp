namespace BookCargos.Model
{
    public interface ICargos
    {
        CubicFeet TotalSize();
        void Add(Cargo cargo);
        void RemoveAll();
        bool Contains(Cargo cargo);
    }
}