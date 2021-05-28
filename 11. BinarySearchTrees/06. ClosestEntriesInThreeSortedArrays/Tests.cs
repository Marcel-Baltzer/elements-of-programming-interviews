using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._06._ClosestEntriesInThreeSortedArrays
{
    public class Tests
    {
        [Fact]
        public void FindMinDistanceSortedArrays()
        {
            var list = new List<List<int>>
            {
                new() {5, 10, 15},
                new() {3, 6, 9, 12, 15},
                new() {8, 16, 24}
            };

            var result = Solution.FindMinDistanceSortedArrays(list);

            result.Should().Be(1);
        }
    }
}