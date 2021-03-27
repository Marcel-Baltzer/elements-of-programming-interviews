using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.LinkedLists.EvenOddMerge
{
    public class Tests
    {
        [Fact]
        public void EvenOddMerge()
        {
            var fifth = new ListNode<int> { Data = 4, Next = null };
            var fourth = new ListNode<int> { Data = 3, Next = fifth };
            var third = new ListNode<int> { Data = 2, Next = fourth };
            var second = new ListNode<int> { Data = 1, Next = third };
            var first = new ListNode<int> { Data = 0, Next = second };

            var expectedFifth = new ListNode<int> { Data = 3, Next = null };
            var expectedFourth = new ListNode<int> { Data = 1, Next = expectedFifth };
            var expectedThird = new ListNode<int> { Data = 4, Next = expectedFourth };
            var expectedSecond = new ListNode<int> { Data = 2, Next = expectedThird };
            var expectedFirst = new ListNode<int> { Data = 0, Next = expectedSecond };


            var result = Solution.EvenOddMerge(first);

            result.Should().BeEquivalentTo(expectedFirst);
        }
    }
}