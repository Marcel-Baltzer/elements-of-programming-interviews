using Elements_of_Programming_Interviews._04._LinkedLists;

namespace Elements_of_Programming_Interviews._10._Sorting._10._FastSortingAlgorithm
{
    public class Solution
    {
        public static ListNode<int> InsertionSort(ListNode<int> list)
        {
            var dummyHead = new ListNode<int>() {Data = 0, Next = list};
            var iter = list;
            
            // The sublist consisting of nodes up to and including iter is sorted in
            // increasing order. We need to ensure that after we move to iter.next
            // this property continues to hold. We do this by swapping iter.next
            // with its predecessors in the list till it’s in the right place.

            while (iter != null && iter.Next != null)
            {
                if (iter.Data > iter.Next.Data)
                {
                    var target = iter.Next;
                    var pre = dummyHead;
                    while (pre.Next.Data < target.Data)
                    {
                        pre = pre.Next;
                    }

                    var temp = pre.Next;
                    pre.Next = target;
                    iter.Next = target.Next;
                    target.Next = temp;
                }
                else
                {
                    iter = iter.Next;
                }
            }

            return dummyHead.Next;
        }

        public static ListNode<int> StableSortList(ListNode<int> list)
        {
            // Base cases: L is empty or a single node, nothing to do.
            if (list?.Next == null)
            {
                return list;
            }
            
            // Find the midpoint of L using a slow and a fast pointer.
            ListNode<int> preSlow = null;
            var slow = list;
            var fast = list;
            
            while (fast != null && fast.Next != null)
            {
                preSlow = slow;
                fast = fast.Next.Next;
                slow = slow.Next;
            }

            // Splits the list into two equal-sized lists.
            preSlow.Next = null;

            return Elements_of_Programming_Interviews._04._LinkedLists._01._MergeSortedLists.Solution.MergeTwoSortedLists(StableSortList(list), StableSortList(slow));
        }
    }
}