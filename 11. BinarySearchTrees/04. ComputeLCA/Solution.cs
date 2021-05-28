using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._04._ComputeLCA
{
    public class Solution
    {
        // Input nodes are not null and the key at s is less than or equal to that at b.
        public static BinarySearchTreeNode<int> FindLowestCommonAncestor(BinarySearchTreeNode<int> tree, 
                                                                         BinarySearchTreeNode<int> smallKey, 
                                                                         BinarySearchTreeNode<int> bigKey)
        {
            var p = tree;

            while (p.Data < smallKey.Data || p.Data > bigKey.Data)
            {
                // Keep searching since p is outside of [s, b].
                while (p.Data < smallKey.Data)
                {
                    p = p.Right; // LCA must be in p’s right child.
                }

                while (p.Data > bigKey.Data)
                {
                    p = p.Left; // LCA must be in p’s left child.
                }
            }
            
            //Now, s.data >= p.data && p.data <- b.data.
            return p;
        }
    }
}