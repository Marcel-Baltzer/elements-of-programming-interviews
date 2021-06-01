using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._12._Recursion._05._SubsetsOfSizeK
{
    public static class Solution
    {
        public static IEnumerable<List<int>> Combinations(int n, int k)
        {
            var result = new List<List<int>>();
            DirectedCombinations(n,k,1, new List<int>(), result);
            return result;
        }

        private static void DirectedCombinations(int n, int k, int offset,
            IList<int> partialCombination, ICollection<List<int>> result)
        {
            if (partialCombination.Count == k)
            {
                result.Add(new List<int>(partialCombination));
                return;
            }

            // Generate remaining combinations over {offset , ..., n - 1} of size
            // numRemaining.
            var numRemaining = k - partialCombination.Count;
            for (var i = offset; i <= n && numRemaining <= n - i + 1; i++)
            {
                partialCombination.Add(i);
                DirectedCombinations(n, k, i + 1, partialCombination, result);
                partialCombination.RemoveAt(partialCombination.Count - 1);
            }
        }
    }
}