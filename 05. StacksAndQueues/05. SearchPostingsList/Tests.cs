using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._05._StacksAndQueues._05._SearchPostingsList
{
    public class Tests
    {
        [Fact]
        public void SetJumpOrderRecursive()
        {
            var fourth = new Solution.PostingListNode { Order = -1, Next = null };
            var third = new Solution.PostingListNode { Order = -1, Next = fourth };
            var second = new Solution.PostingListNode { Order = -1, Next = third };
            var first = new Solution.PostingListNode { Order = -1, Next = second };

            first.Jump = third;
            second.Jump = fourth;
            third.Jump = second;
            fourth.Jump = fourth;

            Solution.SetJumpOrderRecursive(first);

            first.Order.Should().Be(0);
            second.Order.Should().Be(2);
            third.Order.Should().Be(1);
            fourth.Order.Should().Be(3);
        }

        [Fact]
        public void SetJumpOrderWithStack()
        {
            var fourth = new Solution.PostingListNode { Order = -1, Next = null };
            var third = new Solution.PostingListNode { Order = -1, Next = fourth };
            var second = new Solution.PostingListNode { Order = -1, Next = third };
            var first = new Solution.PostingListNode { Order = -1, Next = second };

            first.Jump = third;
            second.Jump = fourth;
            third.Jump = second;
            fourth.Jump = fourth;

            Solution.SetJumpOrderWithStack(first);

            first.Order.Should().Be(0);
            second.Order.Should().Be(2);
            third.Order.Should().Be(1);
            fourth.Order.Should().Be(3);
        }
    }
}