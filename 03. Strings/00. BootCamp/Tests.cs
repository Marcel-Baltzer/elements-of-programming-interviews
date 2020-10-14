using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Strings.BootCamp
{

    public class Tests
    {
        [Theory]
        [InlineData("abcba", true)]
        [InlineData("abcde", false)]
        public void IsPalindromic(string s, bool expectedResult)
        {
            var result = Solution.IsPalindromic(s);

            result.Should().Be(expectedResult);
        }
    }
}