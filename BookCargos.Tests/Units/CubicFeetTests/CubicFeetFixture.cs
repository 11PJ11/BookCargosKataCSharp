using System;
using BookCargos.Model;
using FluentAssertions;
using NUnit.Framework;

namespace BookCargos.Tests.Units.CubicFeetTests
{
    [TestFixture]
    public class CubicFeetFixture
    {
    }

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

}