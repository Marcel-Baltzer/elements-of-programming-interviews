using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._09._HashTables._09._LongestSubarray
{
    public class Tests
    {
        [Fact]
        public void LongestSubarrayWithDistinctEntries()
        {
            var list = new List<int> {6, 19, 6, 5, 20, 23, 5, 14, 23, 5};

            var result = Solution.LongestSubarrayWithDistinctEntries(list);

            result.Should().Be(5);
        }
    }
}