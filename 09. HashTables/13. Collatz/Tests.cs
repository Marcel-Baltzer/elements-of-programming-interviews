using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.HashTables.Collatz
{
    public class Tests
    {
        [Fact]
        public void TestCollatzConjecture()
        {
            var result = Solution.TestCollatzConjecture(11);

            result.Should().BeTrue();
        }
    }
}