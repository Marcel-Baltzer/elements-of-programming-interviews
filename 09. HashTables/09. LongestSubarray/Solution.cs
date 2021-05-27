using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._09._HashTables._09._LongestSubarray
{
    public class Solution
    {
        public static int LongestSubarrayWithDistinctEntries(List<int> A)
        {
            // Records the most recent occurrences of each entry.
            var mostRecentOccurrence = new Dictionary<int, int>();
            var longestDubFreeSubarrayStartIdx = 0;
            var result = 0;

            for (var i = 0; i < A.Count; ++i)
            {
                // A[i] appeared before. 
                // Did it appear in the longest current subarray?
                if (mostRecentOccurrence.ContainsKey(A[i]))
                {
                    var dubIdx = mostRecentOccurrence[A[i]];
                    if (dubIdx >= longestDubFreeSubarrayStartIdx)
                    {
                        result = Math.Max(result, i - longestDubFreeSubarrayStartIdx);
                        longestDubFreeSubarrayStartIdx = dubIdx + 1;
                    }
                }
                
                mostRecentOccurrence[A[i]] = i;
            }

            result = Math.Max(result, A.Count - longestDubFreeSubarrayStartIdx);
            return result;
        }
    }
}