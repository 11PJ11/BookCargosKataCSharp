using BookCargos.Model;
using FluentAssertions;
using NUnit.Framework;

namespace BookCargos.Tests.Units.CubicFeetTests
{
    public class WhenAddingCubicFeetShould
    {
        [Test]
        public void ReturnCurrentCubicFeetGivenIsAddedToZeroCubicFeet()
        {
            var current = new CubicFeet(40);

            var total = current + CubicFeet.Zero;

            total.Should().Be(current);
        }

        [Test]
        public void ReturnTotalCubicFeetGivenAddingTwoCubicFeet()
        {
            var cf1 = new CubicFeet(40);
            var cf2 = new CubicFeet(5);

            var total = cf1 + cf2;

            total.Should().Be(new CubicFeet(45));
        }
    }
}