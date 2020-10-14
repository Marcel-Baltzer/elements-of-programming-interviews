using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Strings.InterconvertStringsAndIntegers
{
    public class Tests
    {
        [Theory]
        [InlineData(0, "0")]
        [InlineData(509, "509")]
        [InlineData(-123, "-123")]
        public void IntToString(int number, string expectedResult)
        {
            var result = Solution.IntToString(number);

            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("0", 0)]
        [InlineData("509", 509)]
        [InlineData("-123", -123)]
        public void StringToInt(string text, int expectedResult)
        {
            var result = Solution.StringToInt(text);

            result.Should().Be(expectedResult);
        }
    }
}