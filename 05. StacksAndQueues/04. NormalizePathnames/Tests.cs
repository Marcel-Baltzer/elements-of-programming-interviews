using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._05._StacksAndQueues._04._NormalizePathnames
{
    public class Tests
    {
        [Fact]
        public void ShortestEquivalentPath()
        {
            var result = Solution.ShortestEquivalentPath("sc//./../tc/awk/././");

            result.Should().Be("tc/awk");
        }
    }
}