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

            var dummyHead = new ListNode<int>() { Data = 0, Next = list };
            var sublistHead = dummyHead;
            var k = 1;

            while (k++ < start)
            {
                sublistHead = sublistHead.Next;
            }

            //Reverse subList.
            var sublistIter = sublistHead.Next;
            while (start++ < finish)
            {
                var temp = sublistIter.Next;
                sublistIter.Next = temp.Next;
                temp.Next = sublistHead.Next;
                sublistHead.Next = temp;
            }

            return dummyHead.Next;
        }
    }
}