using System;
using System.Collections.Generic;
using Castle.Core.Internal;

namespace Elements_of_Programming_Interviews._09._HashTables._10._LongestContainedInterval
{
    public class Solution
    {
        public static int LongestContainedRange(List<int> A)
        {
            // unprocessedEntries records the existence of each entry in A.
            var unprocessedEntries = new HashSet<int>(A);

            var maxIntervalSize = 0;

            while (!unprocessedEntries.IsNullOrEmpty())
            {
                using var enumerator  = unprocessedEntries.GetEnumerator();
                enumerator.MoveNext();
                var a = enumerator.Current;
                
                unprocessedEntries.Remove(a);
                
                // Finds the lower bound of the largest range containing a.
                var lowerBound = a - 1;
                while (unprocessedEntries.Contains(lowerBound))
                {
                    unprocessedEntries.Remove(lowerBound);
                    --lowerBound;
                }
                
                // Finds the upper bound of the largest range containing a.
                var upperBound = a + 1;
                while (unprocessedEntries.Contains(upperBound))
                {
                    unprocessedEntries.Remove(upperBound);
                    ++upperBound;
                }

                maxIntervalSize = Math.Max(upperBound - lowerBound - 1, maxIntervalSize);
            }

            return maxIntervalSize;
        }
    }
}