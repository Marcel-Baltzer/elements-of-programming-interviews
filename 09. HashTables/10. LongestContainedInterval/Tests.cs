using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._09._HashTables._10._LongestContainedInterval
{
    public class Tests
    {
        [Fact]
        public void LongestContainedRange()
        {
            var list = new List<int>() { 3,-2,7,9,8,1,2,0,-1,5,8 };

            var result = Solution.LongestContainedRange(list);

            result.Should().Be(6);
        }
    }
}