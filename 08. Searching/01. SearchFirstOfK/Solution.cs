using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._08._Searching._01._SearchFirstOfK
{
    public class Solution
    {
        public static int SearchFirstOfK(List<int> array, int k)
        {
            var left = 0;
            var right = array.Count - 1;
            var result = -1;

            // A.subList(left , right + 1) is the candidate set
            while (left <= right)
            {
                var mid = left + ((right - left) / 2);

                if (array[mid] > k)
                {
                    right = mid - 1;
                }
                else if (array[mid] == k)
                {
                    result = mid;
                    // Nothing to the right of mid can be the first occurrence of k.
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return result;
        }
    }
}