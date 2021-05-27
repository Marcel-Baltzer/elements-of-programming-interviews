using System;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._08._Searching._05._RealSquareRoot
{
    public class Tests
    {
        [Theory]
        [InlineData(0.25, 0.5)]
        [InlineData(4, 2)]
        [InlineData(100, 10)]
        public void SquareRoot(double input, double expectedResult)
        {
            var result = Solution.SquareRoot(input);

            result = Math.Round(result, 4);
            result.Should().Be(expectedResult);
        }
    }
}