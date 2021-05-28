using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._04._LinkedLists._09._CyclicRightShift
{
    public class Solution
    {
        public static ListNode<int> CyclicallyRightShiftList(ListNode<int> list, int k)
        {
            if (list == null)
            {
                return null;
            }

            // Compute the length of L and the tail.
            var tail = list;
            var n = 1;
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

            var stepsToNewHEad = n - k;
            var newTail = tail;
            while (stepsToNewHEad-- > 0)
            {
                newTail = newTail.Next;
            }

            var newHead = newTail.Next;
            newTail.Next = null;

            return newHead;
        }
    }
}