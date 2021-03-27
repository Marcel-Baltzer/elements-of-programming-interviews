using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.LinkedLists.Pivoting
{
    public class Tests
    {
        [Fact]
        public void ListPivoting()
        {
            var seventh = new ListNode<int> { Data = 11, Next = null };
            var sixth = new ListNode<int> { Data = 5, Next = seventh };
            var fifth = new ListNode<int> { Data = 7, Next = sixth };
            var fourth = new ListNode<int> { Data = 11, Next = fifth };
            var third = new ListNode<int> { Data = 2, Next = fourth };
            var second = new ListNode<int> { Data = 2, Next = third };
            var first = new ListNode<int> { Data = 3, Next = second };

            var expectedSeventh = new ListNode<int> { Data = 11, Next = null };
            var expectedSixth = new ListNode<int> { Data = 11, Next = expectedSeventh };
            var expectedFifth = new ListNode<int> { Data = 7, Next = expectedSixth };
            var expectedFourth = new ListNode<int> { Data = 5, Next = expectedFifth };
            var expectedThird = new ListNode<int> { Data = 2, Next = expectedFourth };
            var expectedSecond = new ListNode<int> { Data = 2, Next = expectedThird };
            var expectedFirst = new ListNode<int> { Data = 3, Next = expectedSecond };


            var result = Solution.ListPivoting(first, 7);

            result.Should().BeEquivalentTo(expectedFirst);
        }
    }
}