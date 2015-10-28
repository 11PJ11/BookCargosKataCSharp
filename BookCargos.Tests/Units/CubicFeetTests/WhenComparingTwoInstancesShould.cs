using BookCargos.Model;
using FluentAssertions;
using NUnit.Framework;

namespace BookCargos.Tests.Units.CubicFeetTests
{
    public class WhenComparingTwoInstancesShould
    {
        [Test]
        public void ReturnFalseGivenTheyHaveDifferentValues()
        {
            var hundredCubicFeet = new CubicFeet(100);
            var tenCubicFeet = new CubicFeet(10);

            hundredCubicFeet.Should().NotBe(tenCubicFeet);
        }

        [Test]
        public void ReturnTrueGivenTheyHaveEqualValues()
        {
            var hundredCubicFeetA = new CubicFeet(100);
            var hundredCubicFeetB = new CubicFeet(100);

            hundredCubicFeetA.Should().Be(hundredCubicFeetB);
        }
    }

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