namespace BookCargos.Model
{
    public class Cargo
    {
        private readonly CubicFeet _size;
        private Cargo() { }
        private Cargo(CubicFeet size)
        {
            _size = size;
        }

        public static Cargo WithSize(CubicFeet size)
        {
            return new Cargo(size);
        }

        public void BookOn(Vessel vessel)
        {
        }
    }
}