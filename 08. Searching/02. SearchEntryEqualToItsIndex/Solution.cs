using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._08._Searching._02._SearchEntryEqualToItsIndex
{
    public class Solution
    {
        public static int SearchEntryEqualToItsIndex(List<int> A)
        {
            int left = 0;
            int right = A.Count - 1;

            while (left <= right)
            {
                int mid = left + ((right - left) / 2);
                int difference = A[mid] - mid;
                // A[mid] == mid if and only if difference == 0.
                if (difference == 0)
                {
                    return mid;
                }
                else if (difference > 0)
                {
                    right = mid - 1;
                }
                else // difference < 0.
                {
                    left = mid + 1;
                }
            }

            return -1;
        }
    }
}