using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Strings.LookAndSayProblem
{
    public class Tests
    {
        [Fact]
        public void LookAndSay()
        {
            var result = Solution.LookAndSay(8);

            result.Should().Be("1113213211");
        }
    }
}