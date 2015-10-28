using BookCargos.Model;
using FluentAssertions;
using NUnit.Framework;

namespace BookCargos.Tests.Units.CubicFeetTests
{
    public class WhenCreatingCubicFeetShould
    {
        [Test]
        public void ReturnZeroCubicFeetGivenNegativeValue()
        {
            var negativeCubicFeet = new CubicFeet(-100);

            negativeCubicFeet.Should().Be(CubicFeet.Zero);
        }
    }
}