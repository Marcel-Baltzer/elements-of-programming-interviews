using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._02._Arrays._04._AdvanceThrough
{
    public class Solution
    {
        public static bool CanReachEnd(List<int> maxAdvanceSteps)
        {
            var furthestReachSoFar = 0;
            var lastIndex = maxAdvanceSteps.Count -1;

            for(var i = 0; i <= furthestReachSoFar && furthestReachSoFar < lastIndex; i++)
            {
                furthestReachSoFar = Math.Max(furthestReachSoFar, i + maxAdvanceSteps[i]);
            }

            return furthestReachSoFar >= lastIndex;
        }
    }
}