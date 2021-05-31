using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._12._Recursion._00._BootCamp
{
    public class Tests
    {
        [Fact]
        public void GreatestCommonDivisor()
        {
            var result = Solution.GreatestCommonDivisor(156, 36);

            result.Should().Be(12);
        }
    }
}