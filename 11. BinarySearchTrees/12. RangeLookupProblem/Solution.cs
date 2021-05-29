using System.Collections.Generic;
using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._12._RangeLookupProblem
{
    public class Solution
    {
        public class Interval
        {
            public readonly int Left;
            public readonly int Right;

            public Interval(int left, int right)
            {
                Left = left;
                Right = right;
            }
        }

        public static List<int> RangeLookupInBinarySearchTree(BinarySearchTreeNode<int> tree, Interval interval)
        {
            var result = new List<int>();
            RangeLookUpInBinarySearchTreeHelper(tree, interval, result);
            return result;
        }

        private static void RangeLookUpInBinarySearchTreeHelper(BinarySearchTreeNode<int> tree, Interval interval,
            ICollection<int> result)
        {
            if (tree == null)
            {
                return;
            }

            if (interval.Left <= tree.Data && tree.Data <= interval.Right)
            {
                RangeLookUpInBinarySearchTreeHelper(tree.Left, interval, result);
                result.Add(tree.Data);
                RangeLookUpInBinarySearchTreeHelper(tree.Right, interval, result);
            }
            else if (interval.Left > tree.Data)
            {
                RangeLookUpInBinarySearchTreeHelper(tree.Right, interval, result);
            }
            else // interval.right >= tree.data
            {
                RangeLookUpInBinarySearchTreeHelper(tree.Left, interval, result);
            }
        }
    }
}