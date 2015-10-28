using System;

namespace BookCargos.Model
{
    public class CubicFeet
    {
        public CubicFeet(int volume)
        {
            if(volume < 0)
                throw new ArgumentException("Volume can't be negative");
        }
    }
}