namespace Elements_of_Programming_Interviews._06._BinaryTrees._06._FindRootToLeafPath
{
    public class Solution
    {
        public static bool HasPathSum(BinaryTreeNode<int> tree, int targetSum)
        {
            return HasPathSumHelper(tree, 0, targetSum);
        }

        private static bool HasPathSumHelper(BinaryTreeNode<int> node, int partialPathSum, int targetSum)
        {
            if (node == null)
            {
                return false;
            }

            partialPathSum += node.Data;

            if (node.Left == null && node.Right == null) // Leaf.
            {
                return partialPathSum == targetSum;
            }

            // Non-leaf .
            return HasPathSumHelper(node.Left, partialPathSum, targetSum)
                || HasPathSumHelper(node.Right, partialPathSum, targetSum);
        }
    }
}