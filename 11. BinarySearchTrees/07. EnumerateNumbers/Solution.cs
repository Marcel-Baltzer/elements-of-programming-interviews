using System;
using System.Collections.Generic;
using System.Linq;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._07._EnumerateNumbers
{
    public class Solution
    {
        public class APlusBSqrt2 : IComparable
        {
            public readonly int A;
            public readonly int B;
            private readonly double value;

            public APlusBSqrt2(int a, int b)
            {
                A = a;
                B = b;
                value = a + b * Math.Sqrt(2);
            }

            public int CompareTo(object obj)
            {
                if (obj is APlusBSqrt2 that)
                {
                    return value.CompareTo(that.value);
                }

                return -1;
            }
        }

        public static List<APlusBSqrt2> GenerateFirstKsAPlusBSqrt(int k)
        {
            var candidates = new SortedSet<APlusBSqrt2>
            {
                // Initial for 0 + 0 * sqrt(2).
                new(0, 0)
            };

            var result = new List<APlusBSqrt2>();
            while (result.Count < k)
            {
                var nextSmallest = candidates.First();
                result.Add(nextSmallest);

                candidates.Add(new APlusBSqrt2(nextSmallest.A + 1, nextSmallest.B));
                candidates.Add(new APlusBSqrt2(nextSmallest.A, nextSmallest.B + 1));
                candidates.Remove(nextSmallest);
            }

            return result;
        }
    }
}