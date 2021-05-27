using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._03._Strings._05._PalindromiCity
{
    public class Tests
    {
        [Theory]
        [InlineData("A man, a plan, a canal, Panama.", true)]
        [InlineData("Able was I, ere I saw Elba!", true)]
        [InlineData("Ray a Ray", false)]
        public void IsPalindrome(string text, bool expectedResult)
        {
            var result = Solution.IsPalindrome(text);

            result.Should().Be(expectedResult);
        }
    }
}