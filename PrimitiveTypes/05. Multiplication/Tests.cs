using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.PrimitiveTypes.Multiplication
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