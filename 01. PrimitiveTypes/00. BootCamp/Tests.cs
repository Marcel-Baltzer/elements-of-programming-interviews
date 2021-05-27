using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._01._PrimitiveTypes._00._BootCamp
{
    public class Tests
    {
        [Theory]
        [InlineData(0,0)]
        [InlineData(1,1)]
        [InlineData(2,1)]
        [InlineData(3,2)]
        [InlineData(4,1)]
        [InlineData(5,2)]
        [InlineData(6,2)]
        [InlineData(7,3)]
        public void CountBits(int number, int expectedResult)
        {
            var result = Solution.CountBits(number);

            result.Should().Be(expectedResult);
        }
    }
}