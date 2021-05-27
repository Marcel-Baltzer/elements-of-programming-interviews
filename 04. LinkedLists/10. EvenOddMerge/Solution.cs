using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._04._LinkedLists._10._EvenOddMerge
{
    public class Solution
    {
        public static ListNode<int> EvenOddMerge(ListNode<int> list)
        {
            if (list == null)
            {
                return null;
            }

            var evenDummyHead = new ListNode<int>();
            var oddDummyHead = new ListNode<int>();

            var tails = new List<ListNode<int>> { evenDummyHead, oddDummyHead };

            var turn = 0;

            for (var iter = list; iter != null; iter = iter.Next)
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