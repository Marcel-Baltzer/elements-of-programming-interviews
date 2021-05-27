using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._09._HashTables._06._NearestRepeatedEntries
{
    public class Solution
    {
        public static int FindNearestRepetition(List<string> paragraph)
        {
            var wordToLatestIndex = new Dictionary<string, int>();
            var nearestRepeatedDistance = int.MaxValue;

            for (var i = 0; i < paragraph.Count; ++i)
            {
                if (wordToLatestIndex.ContainsKey(paragraph[i]))
                {
                    nearestRepeatedDistance = Math.Min(nearestRepeatedDistance, i - wordToLatestIndex[paragraph[i]]);
                }
                
                wordToLatestIndex[paragraph[i]] =  i;
            }

            return nearestRepeatedDistance;
        }
    }
}