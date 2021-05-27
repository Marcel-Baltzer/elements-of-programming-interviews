using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._04._LinkedLists._10._EvenOddMerge
{
    public class Solution
    {
        public static ListNode<int> EvenOddMerge(ListNode<int> list)
        {
            if (list == null)
            {
                return list;
            }

            ListNode<int> evenDummyHead = new ListNode<int>();
            ListNode<int> oddDummyHead = new ListNode<int>();

            List<ListNode<int>> tails = new List<ListNode<int>>() { evenDummyHead, oddDummyHead };

            int turn = 0;

            for (ListNode<int> iter = list; iter != null; iter = iter.Next)
            {
                tails[turn].Next = iter;
                tails[turn] = tails[turn].Next;
                turn ^= 1;
            }

            tails[1].Next = null;
            tails[0].Next = oddDummyHead.Next;

            return evenDummyHead.Next;
        }
    }
}