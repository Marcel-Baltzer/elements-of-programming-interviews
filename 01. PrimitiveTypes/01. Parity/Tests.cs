using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._01._PrimitiveTypes._01._Parity
{
    public class Tests
    {
        [Theory]
        [InlineData(0,0)]
        [InlineData(1,1)]
        [InlineData(2,1)]
        [InlineData(3,0)]
        [InlineData(4,1)]
        [InlineData(5,0)]
        [InlineData(6,0)]
        [InlineData(7,1)]
        public void BruteForce(long number, short expectedResult)
        {
            var result = Solution.BruteForce(number);

            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(0,0)]
        [InlineData(1,1)]
        [InlineData(2,1)]
        [InlineData(3,0)]
        [InlineData(4,1)]
        [InlineData(5,0)]
        [InlineData(6,0)]
        [InlineData(7,1)]
        public void Parity(long number, short expectedResult)
        {
            var result = Solution.Parity(number);

            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(0,0)]
        [InlineData(1,1)]
        [InlineData(2,1)]
        [InlineData(3,0)]
        [InlineData(4,1)]
        [InlineData(5,0)]
        [InlineData(6,0)]
        [InlineData(7,1)]
        public void ParityWithCache(long number, short expectedResult)
        {
            var result = Solution.ParityWithCache(number);

            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(0,0)]
        [InlineData(1,1)]
        [InlineData(2,1)]
        [InlineData(3,0)]
        [InlineData(4,1)]
        [InlineData(5,0)]
        [InlineData(6,0)]
        [InlineData(7,1)]
        public void ParityWithXor(long number, short expectedResult)
        {
            var result = Solution.ParityWithXor(number);

            result.Should().Be(expectedResult);
        }
    }
}