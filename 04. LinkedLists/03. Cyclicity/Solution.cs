namespace Elements_of_Programming_Interviews.LinkedLists.Cyclicity
{
    public class Solution
    {
        public static ListNode<int> HasCycle(ListNode<int> head)
        {
            ListNode<int> fast = head;
            ListNode<int> slow = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                {
                    // There is a cycle, so now let’s calculate the cycle length.
                    int cycleLen = 0;
                    do
                    {
                        ++cycleLen;
                        fast = fast.Next;
                    } while (slow != fast);

                    // Finds the start of the cycle.
                    ListNode<int> cycleLenAdvancedlter = head;
                    // cycleLenAdvancedlter pointer advances cycleLen first.
                    while (cycleLen-- > 0)
                    {
                        cycleLenAdvancedlter = cycleLenAdvancedlter.Next;
                    }

                    ListNode<int> iter = head;
                    // Both iterators advance in tandem.
                    while (iter != cycleLenAdvancedlter)
                    {
                        iter = iter.Next;
                        cycleLenAdvancedlter = cycleLenAdvancedlter.Next;
                    }
                    return iter; // iter is the start of cycle.
                }
            }

            return null; // no cycle.
        }
    }
}