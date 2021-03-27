using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.LinkedLists.RemoveDuplicates
{
    public class Tests
    {
        [Fact]
        public void RemoveDuplicates()
        {
            var seven = new ListNode<int> { Data = 11, Next = null };
            var sixth = new ListNode<int> { Data = 11, Next = seven };
            var fifth = new ListNode<int> { Data = 7, Next = sixth };
            var fourth = new ListNode<int> { Data = 5, Next = fifth };
            var third = new ListNode<int> { Data = 3, Next = fourth };
            var second = new ListNode<int> { Data = 2, Next = third };
            var first = new ListNode<int> { Data = 2, Next = second };

            var expectedFifth = new ListNode<int> { Data = 11, Next = null };
            var expectedFourth = new ListNode<int> { Data = 7, Next = expectedFifth };
            var expectedThird = new ListNode<int> { Data = 5, Next = expectedFourth };
            var expectedSecond = new ListNode<int> { Data = 3, Next = expectedThird };
            var expectedFirst = new ListNode<int> { Data = 2, Next = expectedSecond };


            var result = Solution.RemoveDuplicates(first);

            result.Should().BeEquivalentTo(expectedFirst);
        }
    }
}