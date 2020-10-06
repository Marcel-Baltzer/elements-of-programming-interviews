using Xunit;
using FluentAssertions;

namespace Elements_of_Programming_Interviews.PrimitiveTypes
{
    public class CountBitsTests
    {
        [Theory]
        [InlineData(0,0)]
        [InlineData(1,1)]
        [InlineData(2,1)]
        [InlineData(3,2)]
        [InlineData(4,1)]
        [InlineData(5,2)]
        [InlineData(6,2)]
        [InlineData(7,3)]
        public void For(int number, int expectedResult){

            var countBits = new CountBits();

            var result = countBits.For(number);

            result.Should().Be(expectedResult);
        }
    }
}