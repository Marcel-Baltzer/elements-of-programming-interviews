namespace Elements_of_Programming_Interviews.LinkedLists.RemoveKthLastElement
{
    public class Solution
    {
        //Assumes L has at least k nodes, deletes the k-th last node in L.
        public static ListNode<int> RemoveKthLast(ListNode<int> list, int k)
        {
            ListNode<int> dummyHead = new ListNode<int>() { Data = 0, Next = list };
            ListNode<int> first = dummyHead.Next;

            while (k-- > 0)
            {
                first = first.Next;
            }

            ListNode<int> second = dummyHead;
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