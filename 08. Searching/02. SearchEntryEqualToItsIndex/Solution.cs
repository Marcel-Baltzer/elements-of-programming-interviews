using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._08._Searching._02._SearchEntryEqualToItsIndex
{
    public class Solution
    {
        public static int SearchEntryEqualToItsIndex(List<int> array)
        {
            var left = 0;
            var right = array.Count - 1;

            while (left <= right)
            {
                var mid = left + ((right - left) / 2);
                var difference = array[mid] - mid;
                // A[mid] == mid if and only if difference == 0.
                if (difference == 0)
                {
                    return mid;
                }

                if (difference > 0)
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