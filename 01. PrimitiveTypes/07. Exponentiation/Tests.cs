using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._01._PrimitiveTypes._07._Exponentiation
{
    public class Tests
    {
        [Fact]
        public void Power()
        {
            var result = Solution.Power(5, 2);

            result.Should().Be(25);
        }
    }
}