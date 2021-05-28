using System.Collections.Generic;
using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._06._BinaryTrees._13._ReconstructPreorderTraversal
{
    public class Solution
    {
        private static int _subtreeIdx;

        public static BinaryTreeNode<int> ReconstructPreorder(List<int?> preorder)
        {
            _subtreeIdx = 0;
            return ReconstructPreorderSubtree(preorder);
        }

        // Reconstructs the subtree that is rooted at subtreeIdx.
        private static BinaryTreeNode<int> ReconstructPreorderSubtree(List<int?> preorder)
        {
            var subtreeKey = preorder[_subtreeIdx];
            _subtreeIdx++;

            if (subtreeKey == null)
            {
                return null;
            }

            var leftSubtree = ReconstructPreorderSubtree(preorder);
            var rightSubtree = ReconstructPreorderSubtree(preorder);

            return new BinaryTreeNode<int>() { Data = subtreeKey.Value, Left = leftSubtree, Right = rightSubtree };
        }
    }
}