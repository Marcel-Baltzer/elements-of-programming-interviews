using System;
using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._06._BinaryTrees._04._LCAWithParent
{
    public class Solution
    {
        public static BinaryTreeNodeWithParent<int> LCA(BinaryTreeNodeWithParent<int> node0, BinaryTreeNodeWithParent<int> node1)
        {
            var depth0 = GetDepth(node0);
            var depth1 = GetDepth(node1);

            // Makes node0 as the deeper node in order to simplify the code.
            if (depth1 > depth0)
            {
                var temp = node0;
                node0 = node1;
                node1 = node0;
            }

            // Ascends from the deeper node.
            var depthDiff = Math.Abs(depth0 - depth1);

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
            var depth = 0;
            while (node.Parent != null)
            {
                depth++;
                node = node.Parent;
            }
            return depth;
        }
    }
}