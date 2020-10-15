using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Strings.FindSubstring
{
    public class Tests
    {
        [Fact]
        public void RabinKarp()
        {
            var result = Solution.RabinKarp("GACGCCA", "CGC");

            result.Should().Be(2);
        }
    }
}