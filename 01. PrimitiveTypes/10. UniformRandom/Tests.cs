using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._01._PrimitiveTypes._10._UniformRandom
{
    public class Tests
    {
        [Fact]
        public void UniformRandom()
        {
            var result = Solution.UniformRandom(123, 186);

            result.Should().BeGreaterOrEqualTo(123);
            result.Should().BeLessOrEqualTo(186);
        }
    }
}