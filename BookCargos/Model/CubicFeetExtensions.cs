namespace BookCargos.Model
{
    public static class CubicFeetExtensions
    {
        public static CubicFeet InCubicFeet(this int volume)
        {
            return new CubicFeet(volume);
        }
        
    }
}