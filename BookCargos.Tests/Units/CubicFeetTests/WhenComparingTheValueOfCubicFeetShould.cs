using BookCargos.Model;
using FluentAssertions;
using NUnit.Framework;

namespace BookCargos.Tests.Units.CubicFeetTests
{
    public class WhenComparingTheValueOfCubicFeetShould
    {
        [TestCase(1,2, true)]
        [TestCase(1,1, true)]
        [TestCase(2,1, false)]
        public void ReturnTheValueOfTheComparisonForLessThanOrEqual(int val1, int val2, bool expVal1LoeVal2)
        {
            var c1 = new CubicFeet(val1);
            var c2 = new CubicFeet(val2);

            var actVal1LoeVal2 = c1 <= c2;

            actVal1LoeVal2.Should().Be(expVal1LoeVal2);
        }
    }
}