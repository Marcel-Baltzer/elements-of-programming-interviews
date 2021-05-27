using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._03._Strings._09._RomanToDecimal
{
    public class Tests
    {
        [Theory]
        [InlineData("LXIV", 64)]
        [InlineData("MCXI", 1111)]
        [InlineData("IC", 99)]
        public void RomanToInterger(string roman, int expectedResult)
        {
            var result = Solution.RomanToInterger(roman);

            result.Should().Be(expectedResult);
        }
    }
}