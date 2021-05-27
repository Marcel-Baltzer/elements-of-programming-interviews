using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._02._Arrays._15._RandomSubset
{
    public class Tests
    {
        [Fact]
        public void RandomSubset()
        {
            var result = Solution.RandomSubset(100, 5);

            result.Should().HaveCount(5);
        }
    }
}