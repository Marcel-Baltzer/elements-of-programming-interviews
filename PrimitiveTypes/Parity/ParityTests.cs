using Xunit;
using FluentAssertions;

namespace Elements_of_Programming_Interviews.PrimitiveTypes.Parity
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
        public void WithBruteForceFor(long number, short expectedResult){

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
        public void For(long number, short expectedResult){

            var parity = new Parity();

            var result = parity.For(number);

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
        public void WithMaskFor(long number, short expectedResult){

            var parity = new Parity();

            var result = parity.WithMaskFor(number);

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
        public void WithXorFor(long number, short expectedResult){

            var parity = new Parity();

            var result = parity.WithXorFor(number);

            result.Should().Be(expectedResult);
        }
    }
}