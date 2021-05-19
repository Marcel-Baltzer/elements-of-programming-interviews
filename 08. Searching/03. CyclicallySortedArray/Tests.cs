using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Searching.CyclicallySortedArray
{
    public class Tests
    {
        [Fact]
        public void SearchSmallest()
        {
            var array = new List<int> { 378, 478, 550, 631, 103, 203, 220, 234, 279, 368 };

            var result = Solution.SearchSmallest(array);

            result.Should().Be(4);
        }
    }
}