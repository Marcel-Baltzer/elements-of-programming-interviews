using System.Collections.Generic;
using Elements_of_Programming_Interviews._04._LinkedLists;

namespace Elements_of_Programming_Interviews.StacksAndQueues.BootCamp.Stack
{
    public class Solution
    {
        public static void PrintLinkedListInReverse(ListNode<int> head)
        {
            var nodes = new Stack<int>();

            while (head != null)
            {
                nodes.Push(head.Data);
                head = head.Next;
            }

            while (nodes.Count > 0)
            {
                System.Console.WriteLine(nodes.Pop());
            }
        }

        
    }
}