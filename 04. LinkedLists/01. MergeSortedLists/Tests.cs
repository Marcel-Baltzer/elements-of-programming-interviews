using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._04._LinkedLists._01._MergeSortedLists
{
    public class Tests
    {
        [Fact]
        public void MergeTwoSortedLists()
        {
            var listOne = new ListNode<int>()
            {
                Data = 1,
                Next = new ListNode<int>()
                {
                    Data = 3,
                    Next = new ListNode<int>()
                    {
                        Data = 5,
                        Next = null
                    }
                }
            };

            var listTwo = new ListNode<int>()
            {
                Data = 2,
                Next = new ListNode<int>()
                {
                    Data = 4,
                    Next = null
                }
            };

            var result = Solution.MergeTwoSortedLists(listOne, listTwo);

            var expectedResult = new ListNode<int>()
            {
                Data = 1,
                Next = new ListNode<int>()
                {
                    Data = 2,
                    Next = new ListNode<int>()
                    {
                        Data = 3,
                        Next = new ListNode<int>()
                        {
                            Data = 4,
                            Next = new ListNode<int>()
                            {
                                Data = 5,
                                Next = null
                            }
                        }
                    }
                }
            };

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}