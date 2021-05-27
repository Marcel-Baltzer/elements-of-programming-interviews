using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._02._Arrays._14._RandomPermutation
{
    public class Solution
    {
        public static List<int> ComputeRandomPermutation(int size)
        {
            var permutation = new List<int>(size);

            for(var i = 0; i < size; i++)
            {
                permutation.Add(i);
            }

            _12._SampleOfflineData.Solution.RandomSampling(permutation.Count, permutation);

            return permutation;
        }
    }
}