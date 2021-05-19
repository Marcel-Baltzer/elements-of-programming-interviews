using System.Collections.Generic;

namespace Elements_of_Programming_Interviews.Searching.SearchFirstOfK
{
    public class Solution
    {
        public static int SearchFirstOfK(List<int> A, int k)
        {
            int left = 0;
            int right = A.Count - 1;
            int result = -1;

            // A.subList(left , right + 1) is the candidate set
            while (left <= right)
            {
                int mid = left + ((right - left) / 2);

                if (A[mid] > k)
                {
                    right = mid - 1;
                }
                else if (A[mid] == k)
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