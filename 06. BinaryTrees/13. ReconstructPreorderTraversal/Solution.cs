using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._06._BinaryTrees._13._ReconstructPreorderTraversal
{
    public class Solution
    {
        private static int subtreeIdx;

        public static BinaryTreeNode<int> ReconstructPreorder(List<int?> preorder)
        {
            subtreeIdx = 0;
            return ReconstructPreorderSubtree(preorder);
        }

        // Reconstructs the subtree that is rooted at subtreeIdx.
        private static BinaryTreeNode<int> ReconstructPreorderSubtree(List<int?> preorder)
        {
            int? subtreeKey = preorder[subtreeIdx];
            subtreeIdx++;

            if (subtreeKey == null)
            {
                return null;
            }

            BinaryTreeNode<int> leftSubtree = ReconstructPreorderSubtree(preorder);
            BinaryTreeNode<int> rightSubtree = ReconstructPreorderSubtree(preorder);

            return new BinaryTreeNode<int>() { Data = subtreeKey.Value, Left = leftSubtree, Right = rightSubtree };
        }
    }
}