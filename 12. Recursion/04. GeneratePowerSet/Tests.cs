using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._12._Recursion._04._GeneratePowerSet
{
    public class Tests
    {
        [Fact]
        public void GeneratePowerSet()
        {
            var array = new List<int> {0, 1, 2};

            var result = Solution.GeneratePowerSet(array);

            var expectedResult = new List<List<int>>
            {
                new(),
                new() {0},
                new() {1},
                new() {2},
                new() {0, 1},
                new() {0, 2},
                new() {1, 2},
                new() {0, 1, 2}
            };

            result.Should().BeEquivalentTo(expectedResult);
        }
        
        [Fact]
        public void GeneratePowerSetWithBitArrays()
        {
            var array = new List<int> {0, 1, 2};

            var result = Solution.GeneratePowerSetWithBitArrays(array);

            var expectedResult = new List<List<int>>
            {
                new(),
                new() {0},
                new() {1},
                new() {2},
                new() {0, 1},
                new() {0, 2},
                new() {1, 2},
                new() {0, 1, 2}
            };

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}