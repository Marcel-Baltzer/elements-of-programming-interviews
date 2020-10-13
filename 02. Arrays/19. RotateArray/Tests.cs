using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Arrays.RotateArray
{
    public class Tests
    {
        [Fact]
        public void RotateMatrix()
        {
            var squareMatrix = new List<List<int>>
            {
                new List<int> { 1, 2, 3, 4},
                new List<int> { 5, 6, 7, 8},
                new List<int> { 9,10,11,12},                
                new List<int> {13,14,15,16}
            };

            Solution.RotateMatrix(squareMatrix);

            var expectedSquareMatrix = new List<List<int>>
            {
                new List<int> {13, 9, 5, 1},
                new List<int> {14,10, 6, 2},
                new List<int> {15,11, 7, 3},                
                new List<int> {16,12, 8, 4}
            };

            squareMatrix.Should().BeEquivalentTo(expectedSquareMatrix, options => options.WithoutStrictOrdering());
        }

        [Fact]
        public void RotatedMatrixClass()
        {
            var squareMatrix = new List<List<int>>
            {
                new List<int> { 1, 2, 3, 4},
                new List<int> { 5, 6, 7, 8},
                new List<int> { 9,10,11,12},                
                new List<int> {13,14,15,16}
            };

            var rotatedMatrix = new Solution.RotatedMatrix(squareMatrix);

            rotatedMatrix.ReadEntry(0,3).Should().Be(1);
            rotatedMatrix.ReadEntry(3,3).Should().Be(4);
            rotatedMatrix.ReadEntry(0,0).Should().Be(13);
            rotatedMatrix.ReadEntry(3,0).Should().Be(16);
        }
    }
}