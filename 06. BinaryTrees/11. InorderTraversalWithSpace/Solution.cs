using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._06._BinaryTrees._11._InorderTraversalWithSpace
{
    public class Solution
    {
        public static List<int> InorderTraversal(BinaryTreeNodeWithParent<int> tree)
        {
            BinaryTreeNodeWithParent<int> prev = null;
            var curr = tree;
            var result = new List<int>();

            while (curr != null)
            {
                BinaryTreeNodeWithParent<int> next;

                if (curr.Parent == prev)
                {
                    // We came down to curr from prev.
                    if (curr.Left != null) // Keep going left.
                    {
                        next = curr.Left;
                    }
                    else
                    {
                        result.Add(curr.Data);
                        // Done with left, so go right if right is not empty.
                        // Otherwise , go up.
                        next = curr.Right ?? curr.Parent;
                    }
                }
                else if (curr.Left == prev)
                {
                    result.Add(curr.Data);
                    // Done with left, so go right if right is not empty. Otherwise , go up.
                    next = curr.Right ?? curr.Parent;
                }
                else // Done with both children , so move up.
                {
                    next = curr.Parent;
                }

                prev = curr;
                curr = next;
            }

            return result;
        }
    }
}