using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._04._LinkedLists._06._DeleteNode
{
    public class Tests
    {
        [Fact]
        public void DeletionFromList()
        {
            var third = new ListNode<int> { Data = 3, Next = null };
            var second = new ListNode<int> { Data = 2, Next = third };
            var first = new ListNode<int> { Data = 1, Next = second };

            var expectSecond = new ListNode<int> { Data = 3, Next = null };
            var expectFirst = new ListNode<int> { Data = 1, Next = expectSecond };

            Solution.DeletionFromList(second);

            first.Should().BeEquivalentTo(expectFirst);
        }
    }
}