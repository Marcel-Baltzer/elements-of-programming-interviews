using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.StacksAndQueues.RpnExpression
{
    public class Tests
    {
        [Fact]
        public void Eval()
        {
            var result = Solution.Eval("3,4,+,2,*,1,+");

            result.Should().Be(15);
        }
    }
}