using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._04._LinkedLists._04._OverlappingListsCycleFree
{
    public class Solution
    {
        public static ListNode<int> OverlappingNoCycleLists(ListNode<int> list1, ListNode<int> list2)
        {
            var list1Length = Length(list1);
            var list2Length = Length(list2);

            // Advances the longer list to get equal length lists.
            if (list1Length > list2Length)
            {
                list1 = AdvanceListByK(list1Length - list2Length, list1);
            }
            else
            {
                list2 = AdvanceListByK(list2Length - list1Length, list2);
            }

            while (list1 != null && list2 != null && list1 != list2)
            {
                list1 = list1.Next;
                list2 = list2.Next;
            }

            return list1; // nullptr implies there is no overlap between LI and L2.
        }

        private static ListNode<int> AdvanceListByK(int k, ListNode<int> list)
        {
            while (k-- > 0)
            {
                list = list.Next;
            }
            return list;
        }

        private static int Length(ListNode<int> list)
        {
            var len = 0;
            while (list != null)
            {
                ++len;
                list = list.Next;
            }
            return len;
        }
    }
}