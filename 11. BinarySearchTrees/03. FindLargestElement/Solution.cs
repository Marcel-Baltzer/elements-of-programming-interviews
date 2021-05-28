using System.Collections.Generic;
using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._03._FindLargestElement
{
    public class Solution
    {
        public static List<int> FindKLargestInBinarySearchTree(BinarySearchTreeNode<int> tree, int k)
        {
            var kLargestElements = new List<int>();
            FindKLargestInBinarySearchTreeHelper(tree, k, kLargestElements);
            return kLargestElements;
        }

        private static void FindKLargestInBinarySearchTreeHelper(BinarySearchTreeNode<int> tree, int k, ICollection<int> kLargestElements)
        {
            // Perform reverse inorder traversal.
            if (tree != null && kLargestElements.Count < k)
            {
                FindKLargestInBinarySearchTreeHelper(tree.Right, k, kLargestElements);
                if (kLargestElements.Count < k)
                {
                    kLargestElements.Add(tree.Data);
                    FindKLargestInBinarySearchTreeHelper(tree.Left, k, kLargestElements);
                }
            }
        }
    }
}