using Elements_of_Programming_Interviews._04._LinkedLists;
using Elements_of_Programming_Interviews.Types;
using Xunit;

namespace Elements_of_Programming_Interviews._05._StacksAndQueues._00._BootCamp._01._Stack
{
    public class Tests
    {
        [Fact]
        public void PrintLinkedListInReverse()
        {
            var fifth = new ListNode<int> { Data = 5, Next = null };
            var fourth = new ListNode<int> { Data = 4, Next = fifth };
            var third = new ListNode<int> { Data = 3, Next = fourth };
            var second = new ListNode<int> { Data = 2, Next = third };
            var first = new ListNode<int> { Data = 1, Next = second };

            Solution.PrintLinkedListInReverse(first);

            Assert.True(true);
        }
    }
}