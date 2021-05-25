using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._10._Sorting._02._MergeTwoSortedArrays
{
    public class Solution
    {
        public static void MergeTwoSortedArrays(List<int> A, int m, List<int> B, int n)
        {
            var a = m - 1;
            var b = n - 1;
            var writeIdx = m + n - 1;

            while (a >= 0 && b >= 0)
            {
                A[writeIdx--] = A[a] > B[b] ? A[a--] : B[b--];
            }

            while (b >= 0)
            {
                A[writeIdx--] = B[b--];
            }
        }
    }
}