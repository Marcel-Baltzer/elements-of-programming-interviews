using Xunit;
using FluentAssertions;

namespace Elements_of_Programming_Interviews.PrimitiveTypes
{
    public class ParityTests
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
        public void WithBruteForceFor(int number, int expectedResult){

            var parity = new Parity();

            var result = parity.WithBruteForceFor(number);

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
        public void For(int number, int expectedResult){

            var parity = new Parity();

            var result = parity.For(number);

            result.Should().Be(expectedResult);
        }
    }
}