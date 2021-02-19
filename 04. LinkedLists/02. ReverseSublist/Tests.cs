using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.LinkedLists.ReverseSublist
{
    public class Tests
    {
        [Fact]
        public void ReverseSublist()
        {
            var list = new ListNode<int>()
            {
                Data = 11,
                Next = new ListNode<int>()
                {
                    Data = 3,
                    Next = new ListNode<int>()
                    {
                        Data = 5,
                        Next = new ListNode<int>()
                        {
                            Data = 7,
                            Next = new ListNode<int>()
                            {
                                Data = 2,
                                Next = null
                            }
                        }
                    }
                }
            };

            var result = Solution.ReverseSublist(list, 2, 4);

            var expectedResult = new ListNode<int>()
            {
                Data = 11,
                Next = new ListNode<int>()
                {
                    Data = 7,
                    Next = new ListNode<int>()
                    {
                        Data = 5,
                        Next = new ListNode<int>()
                        {
                            Data = 3,
                            Next = new ListNode<int>()
                            {
                                Data = 2,
                                Next = null
                            }
                        }
                    }
                }
            };

            result.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }
    }
}