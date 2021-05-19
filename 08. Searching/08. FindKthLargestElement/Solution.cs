using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews.Searching.FindKthLargestElement
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

            public static readonly GreaterThan GREATER_THAN = new GreaterThan();
        }

        // The numbering starts from one, i.e., if A = [3,1,-1,2] then
        // findKthLargest(A, 1) returns 3, findKthLargest(A, 2) returns 2,
        // findKthLargest(A, 3) returns 1, and findKthLargest(A, 4) returns -1.
        public static int FindKthLargest(List<int> A, int k)
        {
            return FindKth(A, k, Compare.GREATER_THAN);
        }

        public static int FindKth(List<int> A, int k, Comparer<int> cmp)
        {
            int left = 0, right = A.Count - 1;
            Random r = new Random(0);

            while (left <= right)
            {
                // Generates a random integer in [left, right].
                int pivotIdx = r.Next(right - left + 1) + left;
                int newPivotIdx = PartitionArountPivot(left, right, pivotIdx, A, cmp);
                if (newPivotIdx == k - 1)
                {
                    return A[newPivotIdx];
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
        private static int PartitionArountPivot(int left, int right, int pivotIdx, List<int> A, Comparer<int> cmp)
        {
            int pivotValue = A[pivotIdx];
            int newPivotIdx = left;

            Swap(A, pivotIdx, right);

            for (int i = left; i < right; ++i)
            {
                if (cmp.Compare(A[i], pivotValue) < 0)
                {
                    Swap(A, i, newPivotIdx++);
                }
            }

            Swap(A, right, newPivotIdx);
            return newPivotIdx;
        }

        static void Swap(IList<int> list, int indexA, int indexB)
        {
            int tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }
    }
}