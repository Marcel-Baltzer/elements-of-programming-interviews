using System.Collections.Generic;

namespace Elements_of_Programming_Interviews.Arrays.RandomPermutation
{
    public class Solution
    {
        public static List<int> ComputeRandomPermutation(int size)
        {
            List<int> permutation = new List<int>(size);

            for(int i = 0; i < size; i++)
            {
                permutation.Add(i);
            }

            SampleOfflineData.Solution.RandomSampling(permutation.Count, permutation);

            return permutation;
        }
    }
}