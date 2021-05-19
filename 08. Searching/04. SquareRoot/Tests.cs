using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Searching.SquareRoot
{
    public class Tests
    {
        [Theory]
        [InlineData(16, 4)]
        [InlineData(300, 17)]
        public void SquareRoot(int input, int expectedResult)
        {
            var result = Solution.SquareRoot(input);

            result.Should().Be(expectedResult);
        }
    }
}