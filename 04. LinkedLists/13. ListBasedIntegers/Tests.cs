using Elements_of_Programming_Interviews.Types;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._04._LinkedLists._13._ListBasedIntegers
{
    public class Tests
    {
        [Fact]
        public void AddTwoNumbers()
        {
            var thirdNumberOne = new ListNode<int> { Data = 4, Next = null };
            var secondNumberOne = new ListNode<int> { Data = 1, Next = thirdNumberOne };
            var firstNumberOne = new ListNode<int> { Data = 3, Next = secondNumberOne };

            var thirdNumberTwo = new ListNode<int> { Data = 9, Next = null };
            var secondNumberTwo = new ListNode<int> { Data = 0, Next = thirdNumberTwo };
            var firstNumberTwo = new ListNode<int> { Data = 7, Next = secondNumberTwo };

            var expectedFourth = new ListNode<int> { Data = 1, Next = null };
            var expectedThird = new ListNode<int> { Data = 3, Next = expectedFourth };
            var expectedSecond = new ListNode<int> { Data = 2, Next = expectedThird };
            var expectedFirst = new ListNode<int> { Data = 0, Next = expectedSecond };


            var result = Solution.AddTwoNumbers(firstNumberOne, firstNumberTwo);

            result.Should().BeEquivalentTo(expectedFirst);
        }
    }
}