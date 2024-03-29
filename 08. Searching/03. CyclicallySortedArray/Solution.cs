using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._08._Searching._03._CyclicallySortedArray
{
    public class Solution
    {
        public static int SearchSmallest(List<int> array)
        {
            var left = 0;
            var right = array.Count - 1;

            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (array[mid] > array[right])
                {
                    // Minimum must be in A.subList(mid + 1, right + 1).
                    left = mid + 1;
                }
                else // A[mid] < A[right].
                {
                    // Minimum cannot be in A.subList(mid + 1, right + 1) so it must be in
                    // A.sublist(left , mid + 1).
                    right = mid;
                }
            }

            // Loop ends when left == right.
            return left;
        }
    }
}