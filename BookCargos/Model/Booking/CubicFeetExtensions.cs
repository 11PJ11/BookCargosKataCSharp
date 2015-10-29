namespace BookCargos.Model.Booking
{
    public static class CubicFeetExtensions
    {
        public static CubicFeet CubicFeet(this int volume)
        {
            return new CubicFeet(volume);
        }
    }
}