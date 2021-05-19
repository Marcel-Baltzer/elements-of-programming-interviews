using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews.Searching.FindMinMax
{
    public class Solution
    {
        public class MinMax
        {
            public int Min;
            public int Max;

            public MinMax(int min, int max)
            {
                this.Min = min;
                this.Max = max;
            }

            public static MinMax MinMaxCheck(int a, int b)
            {
                return b.CompareTo(a) < 0 ? new MinMax(b, a) : new MinMax(a, b);
            }
        }

        public static MinMax FindMinMax(List<int> A)
        {
            if (A.Count <= 1)
            {
                return new MinMax(A[0], A[0]);
            }

            MinMax globalMinMax = MinMax.MinMaxCheck(A[0], A[1]);
            // Process two elements at a time.
            for (int i = 2; i + 1 < A.Count; i += 2)
            {
                MinMax localMinMax = MinMax.MinMaxCheck(A[i], A[i + 1]);
                globalMinMax = new MinMax(Math.Min(globalMinMax.Min, localMinMax.Min),
                                        Math.Max(globalMinMax.Max, localMinMax.Max));
            }

            // If there is odd number of elements in the array, we still
            // need to compare the last element with the existing answer.
            if ((A.Count % 2) != 0)
            {
                globalMinMax = new MinMax(Math.Min(globalMinMax.Min, A[A.Count - 1]),
                                        Math.Max(globalMinMax.Max, A[A.Count - 1]));
            }

            return globalMinMax;
        }
    }
}