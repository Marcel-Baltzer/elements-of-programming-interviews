using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._05._StacksAndQueues._05._SearchPostingsList
{
    public class Solution
    {
        public class PostingListNode
        {
            public int Order;
            public PostingListNode Next;
            public PostingListNode Jump;
        }

        public static void SetJumpOrderRecursive(PostingListNode L)
        {
            SetJumpOrderHelper(L, 0);
        }

        private static int SetJumpOrderHelper(PostingListNode listNode, int order)
        {
            if (listNode != null && listNode.Order == -1)
            {
                listNode.Order = order++;
                order = SetJumpOrderHelper(listNode.Jump, order);
                order = SetJumpOrderHelper(listNode.Next, order);
            }

            return order;
        }

        public static void SetJumpOrderWithStack(PostingListNode listNode)
        {
            var stack = new Stack<PostingListNode>();
            int order = 0;
            stack.Push(listNode);

            while (stack.Count > 0)
            {
                PostingListNode curr = stack.Pop();
                if (curr != null && curr.Order == -1)
                {
                    curr.Order = order++;
                    // Stack is last-in, first -out, and we want to process
                    // the jump node first, so push next, then push jump.
                    stack.Push(curr.Next);
                    stack.Push(curr.Jump);
                }
            }
        }
    }
}