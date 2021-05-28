using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._02._FindGreaterKey
{
    public class Solution
    {
        public static BinarySearchTreeNode<int> FindFirstGreaterThanK(BinarySearchTreeNode<int> tree, int k)
        {
            var subtree = tree;
            BinarySearchTreeNode<int> firstSoFar = null;

            while (subtree != null)
            {
                if (subtree.Data > k)
                {
                    firstSoFar = subtree;
                    subtree = subtree.Left;
                }
                else // Root and all keys in left-subtree are <= k, so skip them.
                {
                    subtree = subtree.Right;
                }
            }

            return firstSoFar;
        }
    }
}