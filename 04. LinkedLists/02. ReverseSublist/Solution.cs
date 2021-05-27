namespace Elements_of_Programming_Interviews._04._LinkedLists._02._ReverseSublist
{
    public class Solution
    {
        public static ListNode<int> ReverseSublist(ListNode<int> list, int start, int finish)
        {
            if (start == finish)
            {
                // No need to reverse since start == finish.
                return list;
            }

            ListNode<int> dummyHead = new ListNode<int>() { Data = 0, Next = list };
            ListNode<int> sublistHead = dummyHead;
            int k = 1;

            while (k++ < start)
            {
                sublistHead = sublistHead.Next;
            }

            //Reverse subList.
            ListNode<int> sublistIter = sublistHead.Next;
            while (start++ < finish)
            {
                ListNode<int> temp = sublistIter.Next;
                sublistIter.Next = temp.Next;
                temp.Next = sublistHead.Next;
                sublistHead.Next = temp;
            }

            return dummyHead.Next;
        }
    }
}