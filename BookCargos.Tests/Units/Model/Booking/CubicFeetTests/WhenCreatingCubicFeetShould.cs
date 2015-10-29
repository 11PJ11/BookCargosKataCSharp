using System;
using BookCargos.Model.Booking;
using FluentAssertions;
using NUnit.Framework;

namespace BookCargos.Tests.Units.Model.Booking.CubicFeetTests
{
    public class WhenCreatingCubicFeetShould
    {
        [Test]
        public void ThrowExceptionGivenNegativeVolume()
        {
            Action cubicFeetCreation = () => new CubicFeet(-1);

            cubicFeetCreation.ShouldThrow<ArgumentException>();
        }
    }
}
