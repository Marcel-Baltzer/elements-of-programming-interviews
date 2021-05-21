using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.HashTables.PalindromicPermutations
{
    public class Tests
    {
        [Theory]
        [InlineData("abcabc", true)]
        [InlineData("abcdef", false)]
        public void CanFormPalindrome(string s, bool expectedResult)
        {
            var result = Solution.CanFormPalindrome(s);

            result.Should().Be(expectedResult);
        }
    }
}