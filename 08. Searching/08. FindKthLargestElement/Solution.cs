using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._08._Searching._08._FindKthLargestElement
{
    public class Solution
    {
        private class Compare
        {
            public class GreaterThan : Comparer<int>
            {
                public override int Compare(int a, int b)
                {
                    return (a > b) ? -1 : (a.Equals(b)) ? 0 : 1;
                }
            }

            public static readonly GreaterThan GREATER_THAN = new();
        }

        // The numbering starts from one, i.e., if A = [3,1,-1,2] then
        // findKthLargest(A, 1) returns 3, findKthLargest(A, 2) returns 2,
        // findKthLargest(A, 3) returns 1, and findKthLargest(A, 4) returns -1.
        public static int FindKthLargest(List<int> array, int k)
        {
            return FindKth(array, k, Compare.GREATER_THAN);
        }

        private static int FindKth(IList<int> array, int k, IComparer<int> cmp)
        {
            int left = 0, right = array.Count - 1;
            var r = new Random(0);

            while (left <= right)
            {
                // Generates a random integer in [left, right].
                var pivotIdx = r.Next(right - left + 1) + left;
                var newPivotIdx = PartitionAroundPivot(left, right, pivotIdx, array, cmp);
                if (newPivotIdx == k - 1)
                {
                    return array[newPivotIdx];
                }
                else if (newPivotIdx > k - 1)
                {
                    right = newPivotIdx - 1;
                }
                else
                {
                    left = newPivotIdx + 1;
                }
            }

            return int.MinValue;
        }

        // Partitions A.subList(left , right+1) around pivotIdx , returns the new index
        // of the pivot, newPivotIdx, after partition. After partitioning,
        // A.subList(left, newPivotIdx) contains elements that are less than the
        // pivot, and A.subList(newPivotIdx + 1 , right + 1) contains elements that
        // are greater than the pivot.
        //
        // Note: "less than" is defined by the Comparator object.
        //
        // Returns the new index of the pivot element after partition.
        private static int PartitionAroundPivot(int left, int right, int pivotIdx, IList<int> array, IComparer<int> cmp)
        {
            var pivotValue = array[pivotIdx];
            var newPivotIdx = left;

            Swap(array, pivotIdx, right);

            for (var i = left; i < right; ++i)
            {
                if (cmp.Compare(array[i], pivotValue) < 0)
                {
                    Swap(array, i, newPivotIdx++);
                }
            }

            Swap(array, right, newPivotIdx);
            return newPivotIdx;
        }

        private static void Swap(IList<int> list, int indexA, int indexB)
        {
            var tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }
    }
}