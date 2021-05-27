namespace Elements_of_Programming_Interviews._06._BinaryTrees._02._Symmetric
{
    public class Solution
    {
        public static bool IsSymmetric(BinaryTreeNode<int> tree)
        {
            return tree == null || CheckSymmetric(tree.Left, tree.Right);
        }

        private static bool CheckSymmetric(BinaryTreeNode<int> subtreeLeft, BinaryTreeNode<int> subtreeRight)
        {
            if (subtreeLeft == null && subtreeRight == null)
            {
                return true;
            }
            else if (subtreeLeft != null && subtreeRight != null)
            {
                return subtreeLeft.Data == subtreeRight.Data
                    && CheckSymmetric(subtreeLeft.Left, subtreeRight.Right)
                    && CheckSymmetric(subtreeLeft.Right, subtreeRight.Left);
            }

            // One subtree is empty, and the other is not.
            return false;
        }
    }
}