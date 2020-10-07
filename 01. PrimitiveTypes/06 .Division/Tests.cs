using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.PrimitiveTypes.Division
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