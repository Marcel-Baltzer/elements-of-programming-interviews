using System.Collections.Generic;
using System.Linq;

namespace Elements_of_Programming_Interviews._12._Recursion._03._GeneratePermutations
{
    public static class Solution
    {
        // Solution One
        
        public static IEnumerable<List<int>> Permutations(List<int> array)
        {
            var result = new List<List<int>>();
            DirectedPermutations(0, array, result);
            return result;
        }

        private static void DirectedPermutations(int i, IList<int> array, ICollection<List<int>> result)
        {
            if (i == array.Count - 1)
            {
                result.Add(new List<int>(array));
                return;
            }

            // Try every possibility for array[i].
            for (var j = i; j < array.Count; j++)
            {
                Swap(array, i, j);
                // Generate all permutations for array.Range(i + 1, A.Count).
                DirectedPermutations(i + 1, array, result);
                Swap(array, i, j);
            }
        }

        private static void Swap<T>(IList<T> list, int i, int j)
        {
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
        
        // Solution Two

        public static IEnumerable<List<int>> PermutationsWithComputeNextPermutationSolution(List<int> array)
        {
            var result = new List<List<int>>();

            array.Sort();
            do
            {
                result.Add(new List<int>(array));
                array = Elements_of_Programming_Interviews._02._Arrays._11._ComputeNextPermutation
                    .Solution.NextPermutation(array);
            } while (array.Any());
            
            return result;
        }
    }
}