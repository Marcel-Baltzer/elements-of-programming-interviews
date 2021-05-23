using System;
using System.Collections.Generic;
using System.Linq;

namespace Elements_of_Programming_Interviews.HashTables.FrequentQueries
{
    public class Solution
    {
        public static List<string> ComputeFrequentStrings(List<string> A, int k)
        {
            var dict = new Dictionary<string, int>();

            foreach (var a in A)
            {
                if (!dict.ContainsKey(a))
                {
                    dict[a] = 1;
                }
                else
                {
                    dict[a] = dict[a] + 1;
                }
            }

            var distinct = dict.Keys.ToList();

            return FindKth(distinct, k, dict);
        }

        private static List<string> FindKth(List<string> A, int k, Dictionary<string, int> dict)
        {
            int left = 0, right = A.Count - 1;
            var r = new Random(0);

            while (left <= right)
            {
                // Generates a random integer in [left, right].
                var pivotIdx = r.Next(right - left + 1) + left;
                var newPivotIdx = PartitionAroundPivot(left, right, pivotIdx, A, dict);
                if (newPivotIdx == k - 1)
                {
                    return A.Take(k).ToList();
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

            return new List<string>();
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
        private static int PartitionAroundPivot(int left, int right, int pivotIdx, List<string> A, Dictionary<string, int> dict)
        {
            var pivotValue = A[pivotIdx];
            var newPivotIdx = left;

            Swap(A, pivotIdx, right);

            for (var i = left; i < right; ++i)
            {
                var cmp = (dict[A[i]] > dict[pivotValue]) ? -1 : (dict[A[i]].Equals(dict[pivotValue])) ? 0 : 1;
                
                if (cmp < 0)
                {
                    Swap(A, i, newPivotIdx++);
                }
            }

            Swap(A, right, newPivotIdx);
            return newPivotIdx;
        }

        private static void Swap(IList<string> list, int indexA, int indexB)
        {
            var tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }
    }
}