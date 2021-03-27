namespace Elements_of_Programming_Interviews.LinkedLists.CyclicRightShift
{
    public class Solution
    {
        public static ListNode<int> CyclicallyRightShiftList(ListNode<int> list, int k)
        {
            if (list == null)
            {
                return list;
            }

            // Compute the length of L and the tail.
            ListNode<int> tail = list;
            int n = 1;
            while (tail.Next != null)
            {
                n++;
                tail = tail.Next;
            }

            k %= n;

            if (k == 0)
            {
                return list;
            }

            // Makes a cycle by connecting the tail to the head.
            tail.Next = list;

            int stepsToNewHEad = n - k;
            ListNode<int> newTail = tail;
            while (stepsToNewHEad-- > 0)
            {
                newTail = newTail.Next;
            }

            ListNode<int> newHead = newTail.Next;
            newTail.Next = null;

            return newHead;

        }
    }
}