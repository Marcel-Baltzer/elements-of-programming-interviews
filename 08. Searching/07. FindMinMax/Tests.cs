using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._08._Searching._07._FindMinMax
{
    public class Tests
    {
        [Fact]
        public void FindMinMax()
        {
            var array = new List<int>() { 3, 2, 5, 1, 2, 4 };

            var result = Solution.FindMinMax(array);

            result.Min.Should().Be(1);
            result.Max.Should().Be(5);
        }
    }
}