using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.LinkedLists.MergeSortedLists
{
    public class Tests
    {
        [Fact]
        public void MergeTwoSortedLists()
        {
            var ListOne = new ListNode<int>()
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

            var ListTwo = new ListNode<int>()
            {
                Data = 2,
                Next = new ListNode<int>()
                {
                    Data = 4,
                    Next = null
                }
            };

            var result = Solution.MergeTwoSortedLists(ListOne, ListTwo);

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