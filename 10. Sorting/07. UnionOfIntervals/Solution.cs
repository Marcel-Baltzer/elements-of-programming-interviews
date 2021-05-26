using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Elements_of_Programming_Interviews._10._Sorting._07._UnionOfIntervals
{
    public class Solution
    {
        public class Endpoint
        {
            public readonly bool IsClosed;
            public readonly int Value;

            public Endpoint(int value, bool isClosed)
            {
                Value = value;
                IsClosed = isClosed;
            }
        }
        
        public class Interval : IComparable
        {
            public readonly Endpoint Left;
            public Endpoint Right;

            public Interval(Endpoint left, Endpoint right)
            {
                Left = left;
                Right = right;
            }
            public int CompareTo(object obj)
            {
                var that = (Interval) obj;

                if (Left.Value.CompareTo(that.Left.Value) != 0)
                {
                    return Left.Value - that.Left.Value;
                }
                
                // Left endpoints are equal , so now see if one is closed and the
                // other open - closed intervals should appear first.
                if (Left.IsClosed && !that.Left.IsClosed)
                {
                    return -1;
                }

                if (!Left.IsClosed && that.Left.IsClosed)
                {
                    return 1;
                }
                
                return 0;
            }

            public override bool Equals(object obj)
            {
                if (obj == null || obj is not Interval)
                {
                    return false;
                }

                if (this == obj)
                {
                    return true;
                }

                var that = (Interval) obj;
                return Left.Value == that.Left.Value && Left.IsClosed == that.Left.IsClosed;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Left.Value, Left.IsClosed);
            }
        }

        public static List<Interval> UnionOfIntervals(List<Interval> intervals)
        {
            var result = new List<Interval>();
            
            // Empty input.
            if (!intervals.Any())
            {
                return result;
            }
            
            // Sort intervals according to left endpoints of intervals.
            intervals.Sort();
            var curr = intervals[0];

            for (var i = 1; i < intervals.Count; i++)
            {
                if(intervals[i].Left.Value < curr.Right.Value 
                   || (intervals[i].Left.Value == curr.Right.Value
                        && (intervals[i].Left.IsClosed || curr.Right.IsClosed)))
                {
                    if (intervals[i].Right.Value > curr.Right.Value
                        || (intervals[i].Right.Value == curr.Right.Value
                            && intervals[i].Right.IsClosed))
                    {
                        curr.Right = intervals[i].Right;
                    }
                }
                else
                {
                    result.Add(curr);
                    curr = intervals[i];
                }
            }
            
            result.Add(curr);
            return result;
        }
    }
}