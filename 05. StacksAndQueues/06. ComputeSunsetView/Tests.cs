using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._05._StacksAndQueues._06._ComputeSunsetView
{
    public class Tests
    {
        [Fact]
        public void ExamineBuildingsWithSunset()
        {
            var nums = new List<int>() { 1, 2, 3, 1, 2 };

            var result = Solution.ExamineBuildingsWithSunset(nums.GetEnumerator());

            result.Count.Should().Be(2);
            result.Pop().Height.Should().Be(2);
            result.Pop().Height.Should().Be(3);
        }
    }
}