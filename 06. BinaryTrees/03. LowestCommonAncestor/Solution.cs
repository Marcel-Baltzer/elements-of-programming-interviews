using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._06._BinaryTrees._03._LowestCommonAncestor
{
    public class Solution
    {
        private class Status
        {
            public Status(int numTargetNodes, BinaryTreeNode<int> ancestor)
            {
                NumTargetNodes = numTargetNodes;
                Ancestor = ancestor;
            }

            public int NumTargetNodes { get; }
            public BinaryTreeNode<int> Ancestor { get; }
        }

        public static BinaryTreeNode<int> LCA(BinaryTreeNode<int> tree, BinaryTreeNode<int> node0, BinaryTreeNode<int> node1)
        {
            return LcaHelper(tree, node0, node1).Ancestor;
        }

        private static Status LcaHelper(BinaryTreeNode<int> tree, BinaryTreeNode<int> node0, BinaryTreeNode<int> node1)
        {
            if (tree == null)
            {
                return new Status(0, null);
            }

            var leftResult = LcaHelper(tree.Left, node0, node1);
            if (leftResult.NumTargetNodes == 2)
            {
                // Found both nodes in the left subtree.
                return leftResult;
            }

            var rightResult = LcaHelper(tree.Right, node0, node1);
            {
                if (rightResult.NumTargetNodes == 2)
                {
                    // Found both nodes in the right subtree.
                    return rightResult;
                }
            }

            var numTargetNodes = leftResult.NumTargetNodes + rightResult.NumTargetNodes 
                                        + (tree == node0 ? 1 : 0) + (tree == node1 ? 1 : 0);

            return new Status(numTargetNodes, numTargetNodes == 2 ? tree : null);
        }
    }
}