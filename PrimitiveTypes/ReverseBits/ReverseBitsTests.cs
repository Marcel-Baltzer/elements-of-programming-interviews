using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.PrimitiveTypes.ReverseBits
{
    public class ReverseBitsTests
    {
        [Fact]
        public void WithBrutForceFor(){

            var parity = new ReverseBits();

            var result = parity.WithBrutForceFor(1L, 3);

            result.Should().Be(8);
        }

        [Fact]
        public void For(){

            var parity = new ReverseBits();

            var result = parity.For(256L);

            result.Should().Be(36028797018963968L);
        }
    }
}