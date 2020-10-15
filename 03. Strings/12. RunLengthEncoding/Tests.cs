using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Strings.RunLengthEncoding
{
    public class Tests
    {
        [Fact]
        public void Decoding()
        {
            var result = Solution.Decoding("4a1b3c2a");

            result.Should().Be("aaaabcccaa");
        }

        [Fact]
        public void Encoding()
        {
            var result = Solution.Encoding("eeeffffee");

            result.Should().Be("3e4f2e");
        }
    }
}