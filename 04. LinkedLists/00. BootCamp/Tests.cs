using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.LinkedLists.BootCamp
{
    public class Tests
    {
        [Fact]
        public void Search()
        {
            var third = new ListNode<int> { Data = 3, Next = null };
            var second = new ListNode<int> { Data = 2, Next = third };
            var first = new ListNode<int> { Data = 1, Next = second };


            var node = Solution.Search(first, 3);

            node.Data.Should().Be(3);
        }

        [Fact]
        public void SearchShouldReturnNullIfNotFound()
        {
            var third = new ListNode<int> { Data = 3, Next = null };
            var second = new ListNode<int> { Data = 2, Next = third };
            var first = new ListNode<int> { Data = 1, Next = second };


            var node = Solution.Search(first, 5);

            node.Should().BeNull();
        }

        [Fact]
        public void InsertAfter()
        {
            var lastNode = new ListNode<int> { Data = 3, Next = null };
            var first = new ListNode<int> { Data = 1, Next = lastNode };

            var newNode = new ListNode<int> { Data = 2, Next = null };

            Solution.InsertAfter(first, newNode);

            newNode.Next.Should().BeEquivalentTo(lastNode);
            first.Next.Should().BeEquivalentTo(newNode);
        }

        [Fact]
        public void DeleteNextListNode()
        {
            var third = new ListNode<int> { Data = 3, Next = null };
            var second = new ListNode<int> { Data = 2, Next = third };
            var first = new ListNode<int> { Data = 1, Next = second };

            Solution.DeleteNextListNode(first);

            first.Next.Should().BeEquivalentTo(third);
        }
    }
}