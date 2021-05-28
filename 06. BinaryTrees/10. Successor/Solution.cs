using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._06._BinaryTrees._10._Successor
{
    public class Solution
    {
        public static BinaryTreeNodeWithParent<int> FindSuccessor(BinaryTreeNodeWithParent<int> node)
        {
            var iter = node;

            if (iter.Right != null)
            {
                // Find the leftmost element in node’s right subtree.
                iter = iter.Right;

                while (iter.Left != null)
                {
                    iter = iter.Left;
                }
            }

            // Find the closest ancestor whose left subtree contains node.
            while (iter.Parent != null && iter.Parent.Right == iter)
            {
                iter = iter.Parent;
            }

            // A return value of null means node does not have successor , i.e., it is
            // the rightmost node in the tree.
            return iter.Parent;
        }
    }
}