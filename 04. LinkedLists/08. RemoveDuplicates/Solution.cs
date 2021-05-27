namespace Elements_of_Programming_Interviews._04._LinkedLists._08._RemoveDuplicates
{
    public class Solution
    {
        public static ListNode<int> RemoveDuplicates(ListNode<int> list)
        {
            ListNode<int> iter = list;

            while (iter != null)
            {
                // Uses nextDistinct to find the next distinct value.
                ListNode<int> nextDistinct = iter.Next;
                while (nextDistinct != null && nextDistinct.Data == iter.Data)
                {
                    nextDistinct = nextDistinct.Next;
                }

                iter.Next = nextDistinct;
                iter = nextDistinct;
            }
            return list;
        }
    }
}