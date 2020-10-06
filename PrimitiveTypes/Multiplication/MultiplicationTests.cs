using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.PrimitiveTypes.Multiplication
{
    public class MultiplicationTests
    {
        [Fact]
        public void For(){

            var multiply = new Multiplication();

            var result = multiply.For(3, 7);

            result.Should().Be(21);
        }
    }
}