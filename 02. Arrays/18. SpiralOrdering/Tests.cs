using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._02._Arrays._18._SpiralOrdering
{
    public class Tests
    {
        [Fact]
        public void MatrixInSpiralOrder()
        {
            var squareMatrix = new List<List<int>>
            {
                new() { 1, 2, 3, 4, 5},
                new() { 6, 7, 8, 9,10},
                new() {11,12,13,14,15},                
                new() {16,17,18,19,20},
                new() {21,22,23,24,25}
            };

            var result = Solution.MatrixInSpiralOrder(squareMatrix);

            var expectedResult = new List<int> {1,2,3,4,5,10,15,20,25,24,23,22,21,16,11,6,7,8,9,14,19,18,17,12,13};

            result.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }

        [Fact]
        public void MatrixInSpiralOrderWithSingleIteration()
        {
            var squareMatrix = new List<List<int>>
            {
                new() { 1, 2, 3, 4, 5},
                new() { 6, 7, 8, 9,10},
                new() {11,12,13,14,15},                
                new() {16,17,18,19,20},
                new() {21,22,23,24,25}
            };

            var result = Solution.MatrixInSpiralOrderWithSingleIteration(squareMatrix);

            var expectedResult = new List<int> {1,2,3,4,5,10,15,20,25,24,23,22,21,16,11,6,7,8,9,14,19,18,17,12,13};

            result.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }
    }
}