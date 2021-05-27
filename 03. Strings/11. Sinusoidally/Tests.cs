using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._03._Strings._11._Sinusoidally
{
    public class Tests
    {
        [Fact]
        public void SnakeString()
        {
            var result = Solution.SnakeString("Hello World!");

            result.Should().Be("e lHloWrdlo!");
        }
    }
}