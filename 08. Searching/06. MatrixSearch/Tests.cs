using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._08._Searching._06._MatrixSearch
{
    public class Tests
    {
        [Fact]
        public void MatrixSearch()
        {
            var array = new List<List<int>>
            {
                new() {-1,2,4,4,6},
                new() {1,5,5,9,21},
                new() {3,6,6,9,22},
                new() {3,6,8,10,24},
                new() {6,8,9,12,25},
                new() {8,10,12,13,40}
            };

            var result = Solution.MatrixSearch(array, 8);

            result.Should().BeTrue();
        }
    }
}