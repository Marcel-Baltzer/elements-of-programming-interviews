using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._10._Sorting._06._MergingIntervals
{
    public class Tests
    {
        [Fact]
        public void AddInterval()
        {
            var intervals = new List<Solution.Interval>()
            {
                new Solution.Interval(-4, -1),
                new Solution.Interval(0, 2),
                new Solution.Interval(3, 6),
                new Solution.Interval(7, 9),
                new Solution.Interval(11, 12),
                new Solution.Interval(14, 17),
            };
            
            var newInterval = new Solution.Interval(1, 8);

            var result = Solution.AddInterval(intervals, newInterval);

            var expectedResult = new List<Solution.Interval>()
            {
                new Solution.Interval(-4, -1),
                new Solution.Interval(0, 9),
                new Solution.Interval(11, 12),
                new Solution.Interval(14, 17),
            };

            result.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }
    }
}