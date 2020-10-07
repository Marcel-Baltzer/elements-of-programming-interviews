using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.PrimitiveTypes.Palindrome
{
    public class Tests
    {
        [Theory]
        [InlineData(12521, true)]
        [InlineData(123421, false)]
        [InlineData(-1, false)]
        public void IsPalindromeNumber(int number, bool expectedResult)
        {
            var result = Solution.IsPalindromeNumber(number);

            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(12521, true)]
        [InlineData(123421, false)]
        [InlineData(-1, false)]
        public void IsPalindromeNumberAlternative(int number, bool expectedResult)
        {
            var result = Solution.IsPalindromeNumberAlternative(number);

            result.Should().Be(expectedResult);
        }
    }
}