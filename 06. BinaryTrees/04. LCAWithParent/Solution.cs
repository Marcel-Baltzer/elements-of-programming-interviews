using System;
namespace Elements_of_Programming_Interviews.BinaryTrees.LCA
{
    public class Solution
    {
        public static BinaryTreeNodeWithParent<int> LCA(BinaryTreeNodeWithParent<int> node0, BinaryTreeNodeWithParent<int> node1)
        {
            int depth0 = GetDepth(node0);
            int depth1 = GetDepth(node1);

            // Makes node0 as the deeper node in order to simplify the code.
            if (depth1 > depth0)
            {
                BinaryTreeNodeWithParent<int> temp = node0;
                node0 = node1;
                node1 = node0;
            }

            // Ascends from the deeper node.
            int depthDiff = Math.Abs(depth0 - depth1);

            while (depthDiff-- > 0)
            {
                node0 = node0.Parent;
            }

            // Now ascends both nodes until we reach the LCA.
            while (node0 != node1)
            {
                node0 = node0.Parent;
                node1 = node1.Parent;
            }

            return node0;
        }

        private static int GetDepth(BinaryTreeNodeWithParent<int> node)
        {
            int depth = 0;
            while (node.Parent != null)
            {
                depth++;
                node = node.Parent;
            }
            return depth;
        }
    }
}