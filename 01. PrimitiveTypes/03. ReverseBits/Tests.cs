using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._01._PrimitiveTypes._03._ReverseBits
{
    public class Tests
    {
        [Fact]
        public void BrutForce()
        {
            var result = Solution.BrutForce(1L, 3);

            result.Should().Be(8);
        }

        [Fact]
        public void ReverseBits()
        {
            var result = Solution.ReverseBits(256L);

            result.Should().Be(36028797018963968L);
        }
    }
}