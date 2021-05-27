using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._05._StacksAndQueues._03._WellFormedness
{
    public class Tests
    {
        [Fact]
        public void IsWellFormed()
        {
            var result = Solution.IsWellFormed("[()[]{()()}]");

            result.Should().BeTrue();
        }
    }
}