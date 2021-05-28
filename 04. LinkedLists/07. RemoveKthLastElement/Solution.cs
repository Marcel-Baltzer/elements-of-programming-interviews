using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._04._LinkedLists._07._RemoveKthLastElement
{
    public class Solution
    {
        //Assumes L has at least k nodes, deletes the k-th last node in L.
        public static ListNode<int> RemoveKthLast(ListNode<int> list, int k)
        {
            var dummyHead = new ListNode<int>() { Data = 0, Next = list };
            var first = dummyHead.Next;

            while (k-- > 0)
            {
                first = first.Next;
            }

            var second = dummyHead;
            while (first != null)
            {
                second = second.Next;
                first = first.Next;
            }

            //second points to the (k + 1)-th last node, deletes its successor.
            second.Next = second.Next.Next;
            return dummyHead.Next;
        }
    }
}