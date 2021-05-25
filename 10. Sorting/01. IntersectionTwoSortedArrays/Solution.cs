using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._10._Sorting._01._IntersectionTwoSortedArrays
{
    public class Solution
    {
        public static List<int> IntersectTwoSortedArraysWithEquals(List<int> A, List<int> B)
        {
            var intersectionAB = new List<int>();

            for (var i = 0; i < A.Count; ++i)
            {
                if (i == 0 || A[i] != A[i - 1])
                {
                    foreach (var b in B)
                    {
                        if (A[i].Equals(b))
                        {
                            intersectionAB.Add(A[i]);
                            break;
                        }
                    }
                }
            }

            return intersectionAB;
        }

        public static List<int> IntersectTwoSortedArraysWithBinarySearch(List<int> A, List<int> B)
        {
            var intersectionAB = new List<int>();

            for (var i = 0; i < A.Count; i++)
            {
                if ((i == 0 || A[i] != A[i - 1])
                    && B.BinarySearch(A[i]) >= 0)
                {
                    intersectionAB.Add(A[i]);
                }
            }

            return intersectionAB;
        }
        
        public static List<int> IntersectTwoSortedArrays(List<int> A, List<int> B)
        {
            var intersectionAB = new List<int>();
            
            int i = 0, j = 0;
            while (i < A.Count && j < B.Count)
            {
                if (A[i] == B[j] && (i == 0 || A[i] != A[i - 1]))
                {
                    intersectionAB.Add(A[i]);
                    ++i;
                    ++j;
                }
                else if (A[i] < B[j])
                {
                    ++i;
                }
                else // A.get(i) > B.get(j).
                {
                    ++j;
                }
            }

            return intersectionAB;
        }
    }
}