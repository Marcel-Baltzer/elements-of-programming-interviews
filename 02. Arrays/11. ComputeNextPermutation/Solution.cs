using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._02._Arrays._11._ComputeNextPermutation
{
    public class Solution
    {
        private static void Swap<T>(IList<T> list, int i, int j)
        {
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        public static List<int> NextPermutation(List<int> permutation)
        {
            var k = permutation.Count - 2;
            while (k >=0 && permutation[k] >= permutation[k+1])
            {
                k--;
            }

            if(k == -1)
            {
                // permutation is the last possible permutation.
                return new List<int>(); 
            }

            // Swap the smallest entry after index k that is greater than permutation[k].
            // We exploit the fact that permutation.subList(k + 1, permutation.Count) is decreasing
            // so if we search in reverse order, the first entry that is greater than
            // permutation[k] is the smallest such entry.

            for (var i = permutation.Count -1; i > k ; i--)
            {
                if(permutation[i] > permutation[k])
                {
                    Swap(permutation, k, i);
                    break;
                }
            }

            // Since permutation.subList[k + 1, permutation.Count) is in decreasing order, 
            // we can build the smallest dictionary ordering of this subarray by reversing it.
            permutation.Reverse(k+1, permutation.Count-k-1);

            return permutation;
        }
    }
}