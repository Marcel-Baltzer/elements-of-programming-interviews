using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._04._LinkedLists._13._ListBasedIntegers
{
    public class Solution
    {
        public static ListNode<int> AddTwoNumbers(ListNode<int> list1, ListNode<int> list2)
        {
            var dummyHead = new ListNode<int>();
            var placeIter = dummyHead;

            var carry = 0;

            while (list1 != null || list2 != null)
            {
                var sum = carry;

                if (list1 != null)
                {
                    sum += list1.Data;
                    list1 = list1.Next;
                }

                if (list2 != null)
                {
                    sum += list2.Data;
                    list2 = list2.Next;
                }

                placeIter.Next = new ListNode<int> { Data = sum % 10, Next = null };
                carry = sum / 10;
                placeIter = placeIter.Next;
            }

            // carry cannot exceed 1, so we never need to add more than one node.
            if (carry > 0)
            {
                placeIter.Next = new ListNode<int> { Data = carry, Next = null };
            }

            return dummyHead.Next;
        }
    }
}