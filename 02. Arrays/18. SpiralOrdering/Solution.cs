using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._02._Arrays._18._SpiralOrdering
{
    public class Solution
    {
        public static List<int> MatrixInSpiralOrder(List<List<int>> squareMatrix)
        {
            var spiralOrdering = new List<int>();

            for(var offset = 0; offset < Math.Ceiling(0.5 * squareMatrix.Count); offset++)
            {
                MatrixLayerInClockwise(squareMatrix, offset, spiralOrdering);
            }

            return spiralOrdering;
        }

        private static void MatrixLayerInClockwise(List<List<int>> squareMatrix, int offset, List<int> spiralOrdering)
        {
            if(offset == squareMatrix.Count - offset -1)
            {
                // squareMatrix has odd dimension, and we are at its center.
                spiralOrdering.Add(squareMatrix[offset][offset]);
                return;
            }

            for(var column = offset; column < squareMatrix.Count - offset -1; column++)
            {
                spiralOrdering.Add(squareMatrix[offset][column]);
            }

            for(var row = offset; row < squareMatrix.Count - offset -1; row++)
            {
                spiralOrdering.Add(squareMatrix[row][squareMatrix.Count - offset -1]);
            }

            for(var column = squareMatrix.Count - offset -1; column > offset; column--)
            {
                spiralOrdering.Add(squareMatrix[squareMatrix.Count - offset -1][column]);
            }

            for(var row = squareMatrix.Count - offset -1; row > offset; row--)
            {
                spiralOrdering.Add(squareMatrix[row][offset]);
            }
        }

        public static List<int> MatrixInSpiralOrderWithSingleIteration(List<List<int>> squareMatrix)
        {
            var spiralOrdering = new List<int>();

            var shift = new[]
            {
                new[] { 0, 1},
                new[] { 1, 0},
                new[] { 0,-1},
                new[] {-1, 0}                
            };

            var dir = 0;
            var row = 0;
            var column = 0;

            for(var i = 0; i < squareMatrix.Count * squareMatrix.Count; i++)
            {
                spiralOrdering.Add(squareMatrix[row][column]);
                squareMatrix[row][column] = 0;

                var nextRow = row + shift[dir][0];
                var nextColumn = column + shift[dir][1];

                if(nextRow < 0 || nextRow >= squareMatrix.Count ||
                   nextColumn < 0 || nextColumn >= squareMatrix.Count ||
                   squareMatrix[nextRow][nextColumn] ==0)
                 {
                    dir = (dir+1) % 4;
                    nextRow = row + shift[dir][0];
                    nextColumn = column + shift[dir][1];
                 } 

                row = nextRow;
                column = nextColumn;
            }

            return spiralOrdering;
        }
    }
}