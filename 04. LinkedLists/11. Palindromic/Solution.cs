namespace Elements_of_Programming_Interviews.LinkedLists.Palindromic
{
    public class Solution
    {
        public static bool IsLinkedListAPalindrome(ListNode<int> list)
        {
            if (list == null)
            {
                return true;
            }

            // Find the second half oh list.
            ListNode<int> slow = list;
            ListNode<int> fast = list;

            while (fast != null && fast.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
            }

            // Compare the first half and the reversed second half lists.
            ListNode<int> firstHalfIter = list;
            ListNode<int> secondHalfIter = ReverseList(slow);

            while (secondHalfIter != null && firstHalfIter != null)
            {
                if (secondHalfIter.Data != firstHalfIter.Data)
                {
                    return false;
                }

                secondHalfIter = secondHalfIter.Next;
                firstHalfIter = firstHalfIter.Next;
            }

            return true;
        }

        public static ListNode<int> ReverseList(ListNode<int> list)
        {
            ListNode<int> dummyHead = new ListNode<int>() { Data = 0, Next = list };

            ListNode<int> listIter = dummyHead.Next;

            while (listIter.Next != null)
            {
                ListNode<int> temp = listIter.Next;
                listIter.Next = temp.Next;
                temp.Next = dummyHead.Next;
                dummyHead.Next = temp;
            }

            return dummyHead.Next;
        }
    }
}