using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._06._BinaryTrees._08._PreorderTraversal
{
    public class Solution
    {
        public static List<int> PreorderTraversal(BinaryTreeNode<int> tree)
        {
            Stack<BinaryTreeNode<int>> stack = new Stack<BinaryTreeNode<int>>();
            stack.Push(tree);

            var result = new List<int>();

            while (stack.Count > 0)
            {
                var curr = stack.Pop();

                if (curr != null)
                {
                    result.Add(curr.Data);
                    stack.Push(curr.Right);
                    stack.Push(curr.Left);
                }
            }

            return result;
        }
    }
}