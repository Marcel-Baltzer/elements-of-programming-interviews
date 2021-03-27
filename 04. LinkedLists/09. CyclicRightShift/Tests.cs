using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.LinkedLists.CyclicRightShift
{
    public class Tests
    {
        [Fact]
        public void RemoveDuplicates()
        {
            var fifth = new ListNode<int> { Data = 2, Next = null };
            var fourth = new ListNode<int> { Data = 3, Next = fifth };
            var third = new ListNode<int> { Data = 5, Next = fourth };
            var second = new ListNode<int> { Data = 3, Next = third };
            var first = new ListNode<int> { Data = 2, Next = second };

            var expectedFifth = new ListNode<int> { Data = 3, Next = null };
            var expectedFourth = new ListNode<int> { Data = 2, Next = expectedFifth };
            var expectedThird = new ListNode<int> { Data = 2, Next = expectedFourth };
            var expectedSecond = new ListNode<int> { Data = 3, Next = expectedThird };
            var expectedFirst = new ListNode<int> { Data = 5, Next = expectedSecond };


            var result = Solution.CyclicallyRightShiftList(first, 3);

            result.Should().BeEquivalentTo(expectedFirst);
        }
    }
}