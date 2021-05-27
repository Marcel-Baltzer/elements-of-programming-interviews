using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._08._Searching._07._FindMinMax
{
    public class Solution
    {
        public class MinMax
        {
            public readonly int Min;
            public readonly int Max;

            public MinMax(int min, int max)
            {
                Min = min;
                Max = max;
            }

            public static MinMax MinMaxCheck(int a, int b)
            {
                return b.CompareTo(a) < 0 ? new MinMax(b, a) : new MinMax(a, b);
            }
        }

        public static MinMax FindMinMax(List<int> array)
        {
            if (array.Count <= 1)
            {
                return new MinMax(array[0], array[0]);
            }

            var globalMinMax = MinMax.MinMaxCheck(array[0], array[1]);
            // Process two elements at a time.
            for (var i = 2; i + 1 < array.Count; i += 2)
            {
                var localMinMax = MinMax.MinMaxCheck(array[i], array[i + 1]);
                globalMinMax = new MinMax(Math.Min(globalMinMax.Min, localMinMax.Min),
                                        Math.Max(globalMinMax.Max, localMinMax.Max));
            }

            // If there is odd number of elements in the array, we still
            // need to compare the last element with the existing answer.
            if ((array.Count % 2) != 0)
            {
                globalMinMax = new MinMax(Math.Min(globalMinMax.Min, array[array.Count - 1]),
                                        Math.Max(globalMinMax.Max, array[array.Count - 1]));
            }

            return globalMinMax;
        }
    }
}