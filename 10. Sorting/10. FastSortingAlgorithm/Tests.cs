using Elements_of_Programming_Interviews._04._LinkedLists;
using Elements_of_Programming_Interviews.Types;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._10._Sorting._10._FastSortingAlgorithm
{
    public class Tests
    {
        [Fact]
        public void InsertionSort()
        {
            var fifth = new ListNode<int> { Data = 3, Next = null };
            var fourth = new ListNode<int> { Data = 5, Next = fifth };
            var third = new ListNode<int> { Data = 1, Next = fourth };
            var second = new ListNode<int> { Data = 4, Next = third };
            var first = new ListNode<int> { Data = 3, Next = second };

            var expectedFifth = new ListNode<int> { Data = 5, Next = null };
            var expectedFourth = new ListNode<int> { Data = 4, Next = expectedFifth };
            var expectedThird = new ListNode<int> { Data = 3, Next = expectedFourth };
            var expectedSecond = new ListNode<int> { Data = 3, Next = expectedThird };
            var expectedFirst = new ListNode<int> { Data = 1, Next = expectedSecond };

            var result = Solution.InsertionSort(first);
            
            result.Should().BeEquivalentTo(expectedFirst);
        }

        [Fact]
        public void StableSortList()
        {
            var fifth = new ListNode<int> { Data = 3, Next = null };
            var fourth = new ListNode<int> { Data = 5, Next = fifth };
            var third = new ListNode<int> { Data = 1, Next = fourth };
            var second = new ListNode<int> { Data = 4, Next = third };
            var first = new ListNode<int> { Data = 3, Next = second };

            var expectedFifth = new ListNode<int> { Data = 5, Next = null };
            var expectedFourth = new ListNode<int> { Data = 4, Next = expectedFifth };
            var expectedThird = new ListNode<int> { Data = 3, Next = expectedFourth };
            var expectedSecond = new ListNode<int> { Data = 3, Next = expectedThird };
            var expectedFirst = new ListNode<int> { Data = 1, Next = expectedSecond };

            var result = Solution.StableSortList(first);
            
            result.Should().BeEquivalentTo(expectedFirst);
        }
    }
}