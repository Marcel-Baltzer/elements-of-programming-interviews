using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._01._PrimitiveTypes._05._Multiplication
{
    public class Tests
    {
        [Fact]
        public void Multiply()
        {
            var result = Solution.Multiply(3, 7);

            result.Should().Be(21);
        }
    }
}