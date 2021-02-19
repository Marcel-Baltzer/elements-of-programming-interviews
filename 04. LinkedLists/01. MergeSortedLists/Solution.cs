namespace Elements_of_Programming_Interviews.LinkedLists.MergeSortedLists
{
    public class Solution
    {
        public static ListNode<int> MergeTwoSortedLists(ListNode<int> listNodeOne, ListNode<int> listNodeTwo)
        {
            // Creates a placeholder for the result.
            ListNode<int> dummyHead = new ListNode<int>();
            ListNode<int> current = dummyHead;
            ListNode<int> p1 = listNodeOne;
            ListNode<int> p2 = listNodeTwo;

            while (p1 != null && p2 != null)
            {
                if (p1.Data <= p2.Data)
                {
                    current.Next = p1;
                    p1 = p1.Next;
                }
                else
                {
                    current.Next = p2;
                    p2 = p2.Next;
                }

                current = current.Next;
            }

            // Appends the remaining nodes of pi or p2.
            current.Next = p1 != null ? p1 : p2;
            return dummyHead.Next;
        }
    }
}