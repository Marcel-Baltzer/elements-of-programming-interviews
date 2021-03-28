using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.StacksAndQueues.WellFormedness
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