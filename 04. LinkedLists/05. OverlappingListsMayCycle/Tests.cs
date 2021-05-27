using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._04._LinkedLists._05._OverlappingListsMayCycle
{
    public class Tests
    {
        [Fact]
        public void OverlappingListsHasOnlyOnCycleListReturnsNull()
        {
            var fifthOne = new ListNode<int> { Data = 5, Next = null };
            var fourthOne = new ListNode<int> { Data = 4, Next = fifthOne };
            var thirdOne = new ListNode<int> { Data = 3, Next = fourthOne };
            var secondOne = new ListNode<int> { Data = 2, Next = thirdOne };
            var firstOne = new ListNode<int> { Data = 1, Next = secondOne };

            var thirdTwo = new ListNode<int> { Data = 3, Next = null };
            var secondTwo = new ListNode<int> { Data = 2, Next = thirdTwo };
            var firstTwo = new ListNode<int> { Data = 1, Next = secondTwo };

            thirdTwo.Next = firstTwo;

            var result = Solution.OverlappingLists(firstOne, firstTwo);

            result.Should().BeNull();
        }

        [Fact]
        public void OverlappingListsWithDisjointCyclesReturnsNull()
        {
            var fifthOne = new ListNode<int> { Data = 5, Next = null };
            var fourthOne = new ListNode<int> { Data = 4, Next = fifthOne };
            var thirdOne = new ListNode<int> { Data = 3, Next = fourthOne };
            var secondOne = new ListNode<int> { Data = 2, Next = thirdOne };
            var firstOne = new ListNode<int> { Data = 1, Next = secondOne };

            fifthOne.Next = thirdOne;

            var thirdTwo = new ListNode<int> { Data = 3, Next = null };
            var secondTwo = new ListNode<int> { Data = 2, Next = thirdTwo };
            var firstTwo = new ListNode<int> { Data = 1, Next = secondTwo };

            thirdTwo.Next = firstTwo;

            var result = Solution.OverlappingLists(firstOne, firstTwo);

            result.Should().BeNull();
        }

        [Fact]
        public void OverlappingListsWithCommonCycle()
        {
            var thirdCommon = new ListNode<int> { Data = 8, Next = null };
            var secondCommon = new ListNode<int> { Data = 7, Next = thirdCommon };
            var firstCommon = new ListNode<int> { Data = 6, Next = secondCommon };

            thirdCommon.Next = secondCommon;

            var fifthOne = new ListNode<int> { Data = 5, Next = firstCommon };
            var fourthOne = new ListNode<int> { Data = 4, Next = fifthOne };
            var thirdOne = new ListNode<int> { Data = 3, Next = fourthOne };
            var secondOne = new ListNode<int> { Data = 2, Next = thirdOne };
            var firstOne = new ListNode<int> { Data = 1, Next = secondOne };

            var thirdTwo = new ListNode<int> { Data = 3, Next = firstCommon };
            var secondTwo = new ListNode<int> { Data = 2, Next = thirdTwo };
            var firstTwo = new ListNode<int> { Data = 1, Next = secondTwo };

            var result = Solution.OverlappingLists(firstOne, firstTwo);

            result.Data.Should().Be(6);
        }

        [Fact]
        public void OverlappingListsWithOneCycle()
        {
            var thirdCommon = new ListNode<int> { Data = 8, Next = null };
            var secondCommon = new ListNode<int> { Data = 7, Next = thirdCommon };
            var firstCommon = new ListNode<int> { Data = 6, Next = secondCommon };

            var fifthOne = new ListNode<int> { Data = 51, Next = firstCommon };
            var fourthOne = new ListNode<int> { Data = 41, Next = fifthOne };
            var thirdOne = new ListNode<int> { Data = 31, Next = fourthOne };
            var secondOne = new ListNode<int> { Data = 21, Next = thirdOne };
            var firstOne = new ListNode<int> { Data = 11, Next = secondOne };

            var thirdTwo = new ListNode<int> { Data = 32, Next = firstCommon };
            var secondTwo = new ListNode<int> { Data = 22, Next = thirdTwo };
            var firstTwo = new ListNode<int> { Data = 12, Next = secondTwo };

            thirdCommon.Next = secondOne;

            var result = Solution.OverlappingLists(firstOne, firstTwo);

            result.Data.Should().Be(21);
        }
    }
}