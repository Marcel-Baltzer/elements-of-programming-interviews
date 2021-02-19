using System.IO.Pipes;
using System.Collections.Generic;
namespace Elements_of_Programming_Interviews.LinkedLists.BootCamp
{
    public class Solution
    {
        public static ListNode<int> Search(ListNode<int> L, int key)
        {
            while (L != null && L.Data != key)
            {
                L = L.Next;
            }

            // If key was not present in the list, L will have become null.
            return L;
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