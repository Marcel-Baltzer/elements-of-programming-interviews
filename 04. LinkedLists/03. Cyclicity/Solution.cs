using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._04._LinkedLists._03._Cyclicity
{
    public class Solution
    {
        public static ListNode<int> HasCycle(ListNode<int> head)
        {
            var fast = head;
            var slow = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                {
                    // There is a cycle, so now let’s calculate the cycle length.
                    var cycleLen = 0;
                    do
                    {
                        ++cycleLen;
                        fast = fast.Next;
                    } while (slow != fast);

                    // Finds the start of the cycle.
                    var cycleLenAdvancedIter = head;
                    // cycleLenAdvancedIter pointer advances cycleLen first.
                    while (cycleLen-- > 0)
                    {
                        cycleLenAdvancedIter = cycleLenAdvancedIter.Next;
                    }

                    var iter = head;
                    // Both iterators advance in tandem.
                    while (iter != cycleLenAdvancedIter)
                    {
                        iter = iter.Next;
                        cycleLenAdvancedIter = cycleLenAdvancedIter.Next;
                    }
                    return iter; // iter is the start of cycle.
                }
            }
            return null; // no cycle.
        }
    }
}