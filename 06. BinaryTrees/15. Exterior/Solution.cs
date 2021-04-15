using System.Collections.Generic;

namespace Elements_of_Programming_Interviews.BinaryTrees.Exterior
{
    public class Solution
    {
        public static List<BinaryTreeNode<int>> ExteriorBinaryTree(BinaryTreeNode<int> tree)
        {
            var exterior = new List<BinaryTreeNode<int>>();

            if (tree != null)
            {
                exterior.Add(tree);
                exterior.AddRange(LeftBoundaryAndLeaves(tree.Left, true));
                exterior.AddRange(RightBoundaryAndLeaves(tree.Right, true));
            }

            return exterior;
        }

        // Computes the nodes from the root to the leftmost leaf followed by all the
        // leaves in subtreeRoot.
        private static List<BinaryTreeNode<int>> LeftBoundaryAndLeaves(BinaryTreeNode<int> subtreeRoot, bool isBoundary)
        {
            var result = new List<BinaryTreeNode<int>>();

            if (subtreeRoot != null)
            {
                if (isBoundary || IsLeaf(subtreeRoot))
                {
                    result.Add(subtreeRoot);
                }

                result.AddRange(LeftBoundaryAndLeaves(subtreeRoot.Left, isBoundary));
                result.AddRange(LeftBoundaryAndLeaves(subtreeRoot.Right, isBoundary && subtreeRoot.Left == null));
            }

            return result;
        }

        // Computes the leaves in left-to-right order followed by the rightmost leaf
        // to the root path in subtreeRoot.
        private static List<BinaryTreeNode<int>> RightBoundaryAndLeaves(BinaryTreeNode<int> subtreeRoot, bool isBoundary)
        {
            var result = new List<BinaryTreeNode<int>>();

            if (subtreeRoot != null)
            {
                result.AddRange(RightBoundaryAndLeaves(subtreeRoot.Left, isBoundary && subtreeRoot.Right == null));
                result.AddRange(RightBoundaryAndLeaves(subtreeRoot.Right, isBoundary));

                if (isBoundary || IsLeaf(subtreeRoot))
                {
                    result.Add(subtreeRoot);
                }
            }

            return result;
        }

        private static bool IsLeaf(BinaryTreeNode<int> node)
        {
            return node.Left == null && node.Right == null;
        }
    }
}