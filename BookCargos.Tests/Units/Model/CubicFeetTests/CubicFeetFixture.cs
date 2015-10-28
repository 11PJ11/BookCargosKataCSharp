using System;
using BookCargos.Model;
using FluentAssertions;
using NUnit.Framework;

namespace BookCargos.Tests.Units.Model.CubicFeetTests
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
