using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._01._PrimitiveTypes._06_.Division
{
    public class Tests
    {
        [Fact]
        public void Divide()
        {
            var result = Solution.Divide(137, 7);

            result.Should().Be(19);
        }
    }
}