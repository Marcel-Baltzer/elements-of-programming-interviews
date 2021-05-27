using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._02._Arrays._12._SampleOfflineData
{
    public class Solution
    {
        private static void Swap<T>(IList<T> list, int i, int j)
        {
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        public static void RandomSampling(int size, List<int> array)
        {
            var gen = new Random();
            for(var i = 0; i < size; i++)
            {
                //Generate a random int in [i, A.Count - 1]
                Swap(array, i, i + gen.Next(array.Count - i));
            }
        }
    }
}