using System.Collections.Generic;
using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._09._MinimumHeightTreeFromArray
{
    public class Solution
    {
        public static BinarySearchTreeNode<int> BuildMinHeightBinarySearchTreeFromSortedArray(List<int> array)
        {
            return BuildMinHeightBinarySearchTreeFromSortedArrayHelper(array, 0, array.Count);
        }

        // Build a min-height Binary Search Tree over the entries in A.subList(start , end - 1).
        private static BinarySearchTreeNode<int> BuildMinHeightBinarySearchTreeFromSortedArrayHelper(IReadOnlyList<int> array,
            int start, int end)
        {
            if (start >= end)
            {
                return null;
            }

            var mid = start + ((end - start) / 2);

            return new BinarySearchTreeNode<int>
            {
                Data = array[mid],
                Left = BuildMinHeightBinarySearchTreeFromSortedArrayHelper(array, start, mid),
                Right = BuildMinHeightBinarySearchTreeFromSortedArrayHelper(array, mid + 1, end)
            };
        }
    }
}