using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.LinkedLists.RemoveKthLastElement
{
    public class Tests
    {
        [Fact]
        public void RemoveKthLast()
        {
            var fifth = new ListNode<int> { Data = 5, Next = null };
            var fourth = new ListNode<int> { Data = 4, Next = fifth };
            var third = new ListNode<int> { Data = 3, Next = fourth };
            var second = new ListNode<int> { Data = 2, Next = third };
            var first = new ListNode<int> { Data = 1, Next = second };

            var expectedFourth = new ListNode<int> { Data = 5, Next = null };
            var expectedThird = new ListNode<int> { Data = 4, Next = expectedFourth };
            var expectedSecond = new ListNode<int> { Data = 2, Next = expectedThird };
            var expectedFirst = new ListNode<int> { Data = 1, Next = expectedSecond };


            var result = Solution.RemoveKthLast(first, 3);

            result.Should().BeEquivalentTo(expectedFirst);
        }
    }
}