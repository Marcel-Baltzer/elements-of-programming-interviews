using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._12._Recursion._03._GeneratePermutations
{
    public class Tests
    {
        [Fact]
        public void Permutations()
        {
            var array = new List<int> {2, 3, 5, 7};

            var result = Solution.Permutations(array);

            var expectedResult = new List<List<int>>
            {
                new() {2, 3, 5, 7},
                new() {2, 3, 7, 5},
                new() {2, 5, 3, 7},
                new() {2, 5, 7, 3},
                new() {2, 7, 3, 5},
                new() {2, 7, 5, 3},
                new() {3, 2, 5, 7},
                new() {3, 2, 7, 5},
                new() {3, 5, 2, 7},
                new() {3, 5, 7, 2},
                new() {3, 7, 2, 5},
                new() {3, 7, 5, 2},
                new() {5, 2, 3, 7},
                new() {5, 2, 7, 3},
                new() {5, 3, 2, 7},
                new() {5, 3, 7, 2},
                new() {5, 7, 2, 3},
                new() {5, 7, 2, 3},
                new() {7, 2, 3, 5},
                new() {7, 2, 5, 3},
                new() {7, 3, 2, 5},
                new() {7, 3, 5, 2},
                new() {7, 5, 2, 3},
                new() {7, 5, 3, 2}
            };

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}