using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews.HashTables.ComputeLCA
{
    public class Solution
    {
        public static BinaryTreeNodeWithParent<int> LCA(BinaryTreeNodeWithParent<int> node0,
                                                        BinaryTreeNodeWithParent<int> node1)
        {
            var hash = new HashSet<BinaryTreeNodeWithParent<int>>();

            while (node0 != null || node1 != null)
            {
                // Ascend tree in tandem from these two nodes.
                if (node0 != null)
                {
                    if (!hash.Add(node0))
                    {
                        return node0;
                    }

                    node0 = node0.Parent;
                }

                if (node1 != null)
                {
                    if (!hash.Add(node1))
                    {
                        return node1;
                    }

                    node1 = node1.Parent;
                }
            }

            throw new ArgumentException("node0 and node1 are not in the same tree");
        }
    }
    
    public class BinaryTreeNodeWithParent<T>
    {
        public T Data;
        public BinaryTreeNodeWithParent<T> Parent;
        public BinaryTreeNodeWithParent<T> Left, Right;
    }
}