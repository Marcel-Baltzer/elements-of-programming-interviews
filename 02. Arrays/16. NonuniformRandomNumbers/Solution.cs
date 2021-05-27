using System;
using System.Collections.Generic;
using System.Linq;

namespace Elements_of_Programming_Interviews._02._Arrays._16._NonuniformRandomNumbers
{
    public class Solution
    {
public static int NonuniformRandomNumberGeneration(List<int> values, List<double> probabilities)
        {
            var prefixSumOfProbabilities = new List<double> {0.0};

            // Creating the endpoints for the intervals 
            // corresponding to the probabilities.
            foreach(var p in probabilities)
            {
                prefixSumOfProbabilities.Add(prefixSumOfProbabilities.Last() + p);
            }

            var r = new Random();
            // Get a random number in [0.0,1.0).
            var uniform01 = r.NextDouble();
            // Find the index of the interval that uniformSIl lies in.
            var it = prefixSumOfProbabilities.BinarySearch(uniform01);

            if(it < 0)
            {
                // We want the index of the first element in the array which is
                // greater than the key.
                //
                // When a key is not present in the array, BinarySearch()
                // returns the negative of 1 plus the smallest index whose entry
                // is greater than the key.
                //
                // Therefore , if the return value is negative , by taking its absolute
                // value and adding 1 to it , we get the desired index.
                var intervalIdx = (Math.Abs(it) - 1) - 1;
                return values[intervalIdx];
            }
            else
            {
                // We have it >= 0, i.e., uniform0l equals an entry
                // in prefixSumOfProbabilities.
                //
                // Because we uniform0l is a random double, the probability of it
                // equalling an endpoint in prefixSumOfProbabilities is exceedingly low.
                // However, it is not 0, so to be robust we must consider this case.
                return values[it];
            }
        }
    }
}