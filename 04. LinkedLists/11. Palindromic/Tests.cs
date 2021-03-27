using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.LinkedLists.Palindromic
{
    public class Tests
    {
        [Fact]
        public void IsLinkedListAPalindrome()
        {
            var fifth = new ListNode<int> { Data = 2, Next = null };
            var fourth = new ListNode<int> { Data = 4, Next = fifth };
            var third = new ListNode<int> { Data = 5, Next = fourth };
            var second = new ListNode<int> { Data = 4, Next = third };
            var first = new ListNode<int> { Data = 2, Next = second };

            var result = Solution.IsLinkedListAPalindrome(first);

            result.Should().BeTrue();
        }

        [Fact]
        public void ReverseList()
        {
            var fifth = new ListNode<int> { Data = 4, Next = null };
            var fourth = new ListNode<int> { Data = 3, Next = fifth };
            var third = new ListNode<int> { Data = 2, Next = fourth };
            var second = new ListNode<int> { Data = 1, Next = third };
            var first = new ListNode<int> { Data = 0, Next = second };

            var expectedFifth = new ListNode<int> { Data = 0, Next = null };
            var expectedFourth = new ListNode<int> { Data = 1, Next = expectedFifth };
            var expectedThird = new ListNode<int> { Data = 2, Next = expectedFourth };
            var expectedSecond = new ListNode<int> { Data = 3, Next = expectedThird };
            var expectedFirst = new ListNode<int> { Data = 4, Next = expectedSecond };


            var result = Solution.ReverseList(first);

            result.Should().BeEquivalentTo(expectedFirst);
        }
    }
}