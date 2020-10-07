using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.PrimitiveTypes.ReverseDigits
{
    public class Tests
    {
        [Fact]
        public void ReverseDigits()
        {
            var result = Solution.ReverseDigits(123);

            result.Should().Be(321);
        } 
    }
}