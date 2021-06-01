using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._12._Recursion._04._GeneratePowerSet
{
    public static class Solution
    {
        // Solution One
        public static List<List<int>> GeneratePowerSet(List<int> inputSet)
        {
            var powerSet = new List<List<int>>();
            DirectedPowerSet(inputSet, 0, new List<int>(), powerSet);
            return powerSet;
        }

        // Generate all subsets whose intersection with inputSet[<9] , ...,
        // inputSet[toBeSelected - 1] is exactly selectedSoFar.
        private static void DirectedPowerSet(IReadOnlyList<int> inputSet, int toBeSelected, IList<int> selectedSoFar,
            ICollection<List<int>> powerSet)
        {
            if (toBeSelected == inputSet.Count)
            {
                powerSet.Add(new List<int>(selectedSoFar));
                return;
            }

            // Generate all subsets that contain inputSet[toBeSelected].
            selectedSoFar.Add(inputSet[toBeSelected]);
            DirectedPowerSet(inputSet, toBeSelected + 1, selectedSoFar, powerSet);
            // Generate all subsets that do not contain inputSet[toBeSelected].
            selectedSoFar.RemoveAt(selectedSoFar.Count - 1);
            DirectedPowerSet(inputSet, toBeSelected + 1, selectedSoFar, powerSet);
        }

        // Solution Two

        private static readonly double Log2 = Math.Log(2);

        public static List<List<int>> GeneratePowerSetWithBitArrays(List<int> inputSet)
        {
            var powerSet = new List<List<int>>();

            for (var intForSubset = 0; intForSubset < (1 << inputSet.Count); intForSubset++)
            {
                var bitArray = intForSubset;
                var subset = new List<int>();

                while (bitArray != 0)
                {
                    var index = (int) (Math.Log(bitArray & ~(bitArray - 1)) / Log2);
                    subset.Add(inputSet[(index)]);
                    bitArray &= bitArray - 1;
                }

                powerSet.Add(subset);
            }

            return powerSet;
        }
    }
}