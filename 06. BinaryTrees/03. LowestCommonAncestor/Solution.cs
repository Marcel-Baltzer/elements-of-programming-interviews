namespace Elements_of_Programming_Interviews.BinaryTrees.LowestCommonAncestor
{
    public class Solution
    {
        private class Status
        {
            public Status(int numTargetNodes, BinaryTreeNode<int> ancestor)
            {
                this.NumTargetNodes = numTargetNodes;
                this.ancestor = ancestor;
            }

            public int NumTargetNodes { get; set; }
            public BinaryTreeNode<int> ancestor { get; set; }
        }

        public static BinaryTreeNode<int> LCA(BinaryTreeNode<int> tree, BinaryTreeNode<int> node0, BinaryTreeNode<int> node1)
        {
            return LcaHelper(tree, node0, node1).ancestor;
        }

        private static Status LcaHelper(BinaryTreeNode<int> tree, BinaryTreeNode<int> node0, BinaryTreeNode<int> node1)
        {
            if (tree == null)
            {
                return new Status(0, null);
            }

            Status leftResult = LcaHelper(tree.Left, node0, node1);
            if (leftResult.NumTargetNodes == 2)
            {
                // Found both nodes in the left subtree.
                return leftResult;
            }

            Status rightResult = LcaHelper(tree.Right, node0, node1);
            {
                if (rightResult.NumTargetNodes == 2)
                {
                    // Found both nodes in the right subtree.
                    return rightResult;
                }
            }

            int numTargetNodes = leftResult.NumTargetNodes + rightResult.NumTargetNodes
                                + (tree == node0 ? 1 : 0) + (tree == node1 ? 1 : 0);

            return new Status(numTargetNodes, numTargetNodes == 2 ? tree : null);
        }
    }
}