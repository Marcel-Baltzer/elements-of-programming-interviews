using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._10._Sorting._06._MergingIntervals
{
    public class Solution
    {
        public class Interval
        {
            public readonly int Left;
            public readonly int Right;

            public Interval(int left, int right)
            {
                Left = left;
                Right = right;
            }
        }

        public static List<Interval> AddInterval(List<Interval> disjointIntervals, Interval newInterval)
        {
            var i = 0;
            var result = new List<Interval>();
            
            // Processes intervals in disjointIntervals which come before newInterval.
            while (i < disjointIntervals.Count && newInterval.Left > disjointIntervals[i].Right)
            {
                result.Add(disjointIntervals[i]);
                i++;
            }
            
            // Processes intervals in disjointIntervals which overlap with newInterval.
            while (i < disjointIntervals.Count && newInterval.Right >= disjointIntervals[i].Left)
            {
                newInterval = new Interval(
                    Math.Min(newInterval.Left, disjointIntervals[i].Left),
                    Math.Max(newInterval.Right, disjointIntervals[i].Right)
                );
                i++;
            }
            result.Add(newInterval);

            // Processes intervals in disjointIntervals which come after newInterval .
            result.AddRange(disjointIntervals.GetRange(i, disjointIntervals.Count - i));
            return result;
        }
    }
}