using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._12._Recursion._05._SubsetsOfSizeK
{
    public class Tests
    {
        [Fact]
        public void Combinations()
        {
            var result = Solution.Combinations(5, 2);

            var expectedResult = new List<List<int>>
            {
                new() {1, 2},
                new() {1, 3},
                new() {1, 4},
                new() {1, 5},
                new() {2, 3},
                new() {2, 4},
                new() {2, 5},
                new() {3, 4},
                new() {3, 5},
                new() {4, 5}
            };

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}