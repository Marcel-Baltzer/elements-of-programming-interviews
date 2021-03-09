using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.LinkedLists.Cyclicity
{
    public class Tests
    {
        [Fact]
        public void HasCycleReturnsNull()
        {
            var third = new ListNode<int> { Data = 3, Next = null };
            var second = new ListNode<int> { Data = 2, Next = third };
            var first = new ListNode<int> { Data = 1, Next = second };

            var result = Solution.HasCycle(first);

            result.Should().BeNull();
        }

        [Fact]
        public void HasCycle()
        {
            var fifth = new ListNode<int> { Data = 5, Next = null };
            var fourth = new ListNode<int> { Data = 4, Next = fifth };
            var third = new ListNode<int> { Data = 3, Next = fourth };
            var second = new ListNode<int> { Data = 2, Next = third };
            var first = new ListNode<int> { Data = 1, Next = second };

            fifth.Next = second;

            var result = Solution.HasCycle(first);

            result.Data.Should().Be(2);
        }
    }
}