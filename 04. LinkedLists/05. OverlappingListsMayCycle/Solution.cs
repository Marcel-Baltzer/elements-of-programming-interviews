using System;

namespace Elements_of_Programming_Interviews._04._LinkedLists._05._OverlappingListsMayCycle
{
    public class Solution
    {
        public static ListNode<int> OverlappingLists(ListNode<int> list1, ListNode<int> list2)
        {
            // Store the start of cycle of any.
            ListNode<int> root1 = _03._Cyclicity.Solution.HasCycle(list1);
            ListNode<int> root2 = _03._Cyclicity.Solution.HasCycle(list2);

            if (root1 == null && root2 == null)
            {
                // Both lists don't have cycles.
                return _04._OverlappingListsCycleFree.Solution.OverlappingNoCylceLists(list1, list2);
            }
            else if ((root1 != null && root2 == null) || (root1 == null && root2 != null))
            {
                // One list has cycle, and one list has no cycle.
                return null;
            }

            // Both lists have cycles.
            ListNode<int> temp = root2;

            do
            {
                temp = temp.Next;
            } while (temp != root1 && temp != root2);

            // L1 and L2 do nit end in the same cycle.
            if (temp != root1)
            {
                return null; // Cylces are disjoint.
            }

            // L1 and L2 end in the same cyle, locate the overlapping node if they
            // first overlap before cycle starts.
            int stem1Length = Distance(list1, root1);
            int stem2Length = Distance(list2, root2);
            int count = Math.Abs(stem1Length - stem2Length);

            if (stem1Length > stem2Length)
            {
                list1 = AdvanceListByK(stem1Length - stem2Length, list1);
            }
            else
            {
                list2 = AdvanceListByK(stem2Length - stem1Length, list2);
            }

            while (list1 != list2 && list1 != root1 && list2 != root2)
            {
                list1 = list1.Next;
                list2 = list2.Next;
            }

            // If L1 == L2 before reaching root1, it means the overlap first occurs
            // before the cycle starts; otherwise, the first overlapping node is not
            // unique, so we can return any node on the cycle.
            return list1 == list2 ? list1 : root1;


        }

        // Calculate the distance between a and b.
        private static int Distance(ListNode<int> a, ListNode<int> b)
        {
            int distance = 0;

            while (a != b)
            {
                a = a.Next;
                ++distance;
            }

            return distance;
        }

        private static ListNode<int> AdvanceListByK(int k, ListNode<int> list)
        {
            while (k-- > 0)
            {
                list = list.Next;
            }
            return list;
        }
    }
}