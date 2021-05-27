namespace Elements_of_Programming_Interviews._04._LinkedLists._12._Pivoting
{
    public class Solution
    {
        public static ListNode<int> ListPivoting(ListNode<int> list, int k)
        {
            ListNode<int> lessHead = new ListNode<int>();
            ListNode<int> equalHead = new ListNode<int>();
            ListNode<int> greaterHead = new ListNode<int>();
            ListNode<int> lessIter = lessHead;
            ListNode<int> equalIter = equalHead;
            ListNode<int> greaterITer = greaterHead;

            // Populate the three lists.
            ListNode<int> iter = list;

            while (iter != null)
            {
                if (iter.Data < k)
                {
                    lessIter.Next = iter;
                    lessIter = iter;
                }
                else if (iter.Data == k)
                {
                    equalIter.Next = iter;
                    equalIter = iter;
                }
                else // iter.data > x.
                {
                    greaterITer.Next = iter;
                    greaterITer = iter;
                }

                iter = iter.Next;
            }

            // Combines the three lists.
            greaterITer.Next = null;
            equalIter.Next = greaterHead.Next;
            lessIter.Next = equalHead.Next;

            return lessHead.Next;
        }
    }
}