namespace Elements_of_Programming_Interviews._06._BinaryTrees._05._SumRootToLeafPath
{
    public class Solution
    {
        public static int SumRootToLeaf(BinaryTreeNode<int> tree)
        {
            return SumRootToLeafHelper(tree, 0);
        }

        private static int SumRootToLeafHelper(BinaryTreeNode<int> tree, int partialPathSum)
        {
            if (tree == null)
            {
                return 0;
            }

            partialPathSum = partialPathSum * 2 + tree.Data;

            if (tree.Left == null && tree.Right == null)
            {
                // Leaf.
                return partialPathSum;
            }

            // Non-leaf.
            return SumRootToLeafHelper(tree.Left, partialPathSum) + SumRootToLeafHelper(tree.Right, partialPathSum);
        }
    }
}