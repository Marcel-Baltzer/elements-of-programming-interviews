namespace Elements_of_Programming_Interviews._06._BinaryTrees._09._KthNodeInorderTraversal
{
    public class Solution
    {
        public static BinaryTreeNodeWithSize<int> FindKthNodeBinaryTree(BinaryTreeNodeWithSize<int> tree, int k)
        {
            BinaryTreeNodeWithSize<int> iter = tree;

            while (iter != null)
            {
                int leftSize = iter.Left != null ? iter.Left.Size : 0;

                if (leftSize + 1 < k) // k-th node must be in right subtree of iter.
                {
                    k -= (leftSize + 1);
                    iter = iter.Right;
                }
                else if (leftSize == k - 1) // k-th is iter itself.
                {
                    return iter;
                }
                else // k-th node must be in left subtree of iter.
                {
                    iter = iter.Left;
                }
            }

            // If k is between 1 and the tree size, this line is unreachable .
            return null;
        }
    }
}