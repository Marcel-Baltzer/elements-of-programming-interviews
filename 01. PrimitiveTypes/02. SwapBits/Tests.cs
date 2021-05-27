using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._01._PrimitiveTypes._02._SwapBits
{
    public class SwapBitsTests
    {
        [Theory]
        [InlineData(1,1,0,2)]
        [InlineData(8,3,0,1)]
        public void SwapBits(long number,int i, int j, short expectedResult)
        {
            var result = Solution.SwapBits(number, i, j);

            result.Should().Be(expectedResult);
        }
    }
}