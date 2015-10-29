using System;

namespace BookCargos.Model.Booking
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