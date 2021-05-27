namespace Elements_of_Programming_Interviews._04._LinkedLists._00._BootCamp
{
    public class Solution
    {
        public static ListNode<int> Search(ListNode<int> list, int key)
        {
            while (list != null && list.Data != key)
            {
                list = list.Next;
            }

            // If key was not present in the list, L will have become null.
            return list;
        }

        public static void InsertAfter(ListNode<int> node, ListNode<int> newNode)
        {
            newNode.Next = node.Next;
            node.Next = newNode;
        }

        public static void DeleteNextListNode(ListNode<int> aNode)
        {
            aNode.Next = aNode.Next.Next;
        }
    }
}