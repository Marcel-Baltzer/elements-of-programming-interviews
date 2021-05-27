using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._04._LinkedLists._04._OverlappingListsCycleFree
{
    public class Tests
    {
        [Fact]
        public void OverlappingNoCycleListsReturnsNull()
        {
            var fifthOne = new ListNode<int> { Data = 5, Next = null };
            var fourthOne = new ListNode<int> { Data = 4, Next = fifthOne };
            var thirdOne = new ListNode<int> { Data = 3, Next = fourthOne };
            var secondOne = new ListNode<int> { Data = 2, Next = thirdOne };
            var firstOne = new ListNode<int> { Data = 1, Next = secondOne };

            var thirdTwo = new ListNode<int> { Data = 3, Next = null };
            var secondTwo = new ListNode<int> { Data = 2, Next = thirdTwo };
            var firstTwo = new ListNode<int> { Data = 1, Next = secondTwo };

            var result = Solution.OverlappingNoCycleLists(firstOne, firstTwo);

            result.Should().BeNull();
        }

        [Fact]
        public void OverlappingNoCycleLists()
        {
            var secondCommon = new ListNode<int> { Data = 7, Next = null };
            var firstCommon = new ListNode<int> { Data = 6, Next = secondCommon };

            var fifthOne = new ListNode<int> { Data = 5, Next = firstCommon };
            var fourthOne = new ListNode<int> { Data = 4, Next = fifthOne };
            var thirdOne = new ListNode<int> { Data = 3, Next = fourthOne };
            var secondOne = new ListNode<int> { Data = 2, Next = thirdOne };
            var firstOne = new ListNode<int> { Data = 1, Next = secondOne };

            var thirdTwo = new ListNode<int> { Data = 3, Next = firstCommon };
            var secondTwo = new ListNode<int> { Data = 2, Next = thirdTwo };
            var firstTwo = new ListNode<int> { Data = 1, Next = secondTwo };

            var result = Solution.OverlappingNoCycleLists(firstOne, firstTwo);

            result.Data.Should().Be(6);
        }
    }
}