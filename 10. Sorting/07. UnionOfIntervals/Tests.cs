using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._10._Sorting._07._UnionOfIntervals
{
    public class Tests
    {
        [Fact]
        public void UnionOfIntervals()
        {
            var intervals = new List<Solution.Interval>()
            {
                new(new Solution.Endpoint(0, false), new Solution.Endpoint(3, false)),
                new(new Solution.Endpoint(1, true), new Solution.Endpoint(1, true)),
                new(new Solution.Endpoint(2, true), new Solution.Endpoint(4, true)),
                new(new Solution.Endpoint(3, true), new Solution.Endpoint(4, false)),
                new(new Solution.Endpoint(5, true), new Solution.Endpoint(7, false)),
                new(new Solution.Endpoint(7, true), new Solution.Endpoint(8, false)),
                new(new Solution.Endpoint(8, true), new Solution.Endpoint(11, false)),
                new(new Solution.Endpoint(9, false), new Solution.Endpoint(11, true)),
                new(new Solution.Endpoint(12, true), new Solution.Endpoint(14, true)),
                new(new Solution.Endpoint(12, false), new Solution.Endpoint(16, true)),
                new(new Solution.Endpoint(13, false), new Solution.Endpoint(15, false)),
                new(new Solution.Endpoint(16, false), new Solution.Endpoint(17, false)),
            };

            var result = Solution.UnionOfIntervals(intervals);

            var expectedResult = new List<Solution.Interval>()
            {
                new(new Solution.Endpoint(0, false), new Solution.Endpoint(4, true)),
                new(new Solution.Endpoint(5, true), new Solution.Endpoint(11, true)),
                new(new Solution.Endpoint(12, true), new Solution.Endpoint(17, false))
            };

            result.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }
    }
}