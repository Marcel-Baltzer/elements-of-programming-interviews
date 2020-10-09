using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews.Arrays.AdvanceThrough
{
    public class Solution
    {
        public static bool CanReachEnd(List<int> maxAdvanceSteps)
        {
            int furthesReachSoFar = 0;
            int lastIndex = maxAdvanceSteps.Count -1;

            for(int i = 0; i <= furthesReachSoFar && furthesReachSoFar < lastIndex; i++)
            {
                furthesReachSoFar = Math.Max(furthesReachSoFar, i + maxAdvanceSteps[i]);
            }

            return furthesReachSoFar >= lastIndex;
        }
    }
}