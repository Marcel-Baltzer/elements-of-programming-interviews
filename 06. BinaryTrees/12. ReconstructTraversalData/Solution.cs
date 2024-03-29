using System.Collections.Generic;
using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._06._BinaryTrees._12._ReconstructTraversalData
{
    public class Solution
    {
        public static BinaryTreeNode<int> BinaryTreeFromPreorderInorder(List<int> preorder, List<int> inorder)
        {
            var nodeToInorderIdx = new Dictionary<int, int>();

            for (var i = 0; i < inorder.Count; i++)
            {
                nodeToInorderIdx.Add(inorder[i], i);
            }

            return BinaryTreeFromPreorderInorderHelper(preorder, 0, preorder.Count, 0, inorder.Count, nodeToInorderIdx);
        }

        // Builds the subtree with preorder.subList(preorderStart , preorderEnd) and
        // inorder.subList(inorderStart , inorderEnd).
        private static BinaryTreeNode<int> BinaryTreeFromPreorderInorderHelper(List<int> preorder, int preorderStart, int preorderEnd, int inorderStart, int inorderEnd, Dictionary<int, int> nodeToInorderIdx)
        {
            if (preorderEnd <= preorderStart || inorderEnd <= inorderStart)
            {
                return null;
            }

            var rootInorderIdx = nodeToInorderIdx[preorder[preorderStart]];
            var leftSubtreeSize = rootInorderIdx - inorderStart;

            return new BinaryTreeNode<int>
            {
                Data = preorder[preorderStart],
                // Recursively builds the left subtree.
                Left = BinaryTreeFromPreorderInorderHelper(preorder, preorderStart + 1, preorderStart + 1 + leftSubtreeSize, inorderStart, rootInorderIdx, nodeToInorderIdx),
                // Recursively builds the right subtree.
                Right = BinaryTreeFromPreorderInorderHelper(preorder, preorderStart + 1 + leftSubtreeSize, preorderEnd, rootInorderIdx + 1, inorderEnd, nodeToInorderIdx)
            };
        }
    }
}