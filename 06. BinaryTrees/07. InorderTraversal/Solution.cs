using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._06._BinaryTrees._07._InorderTraversal
{
    public class Solution
    {
        public static List<int> InSortedOrder(BinaryTreeNode<int> tree)
        {
            var stack = new Stack<BinaryTreeNode<int>>();
            var curr = tree;

            var result = new List<int>();

            while (stack.Count > 0 || curr != null)
            {
                if (curr != null)
                {
                    stack.Push(curr);
                    // Going left.
                    curr = curr.Left;
                }
                else
                {
                    // Going up.
                    curr = stack.Pop();
                    result.Add(curr.Data);
                    // Going right.
                    curr = curr.Right;
                }
            }

            return result;
        }
    }
}