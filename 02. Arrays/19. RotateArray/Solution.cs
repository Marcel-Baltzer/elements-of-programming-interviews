using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._02._Arrays._19._RotateArray
{
    public class Solution
    {
        public static void RotateMatrix(List<List<int>> squareMatrix)
        {
            var matrixSize = squareMatrix.Count-1;
            
            for(var i = 0; i < (squareMatrix.Count / 2); i++)
            {
                for(var j = i; j < matrixSize -i; j++)
                {
                    // Perform a 4-way exchange.
                    var temp1 = squareMatrix[matrixSize - j][i];
                    var temp2 = squareMatrix[matrixSize - i][matrixSize - j];
                    var temp3 = squareMatrix[j][matrixSize - i];
                    var temp4 = squareMatrix[i][j];

                    squareMatrix[i][j] = temp1;
                    squareMatrix[matrixSize - j][i] = temp2;
                    squareMatrix[matrixSize - i][matrixSize - j] = temp3;
                    squareMatrix[j][matrixSize - i] = temp4;                    
                }
            }
        }

        public class RotatedMatrix
        {
            private readonly List<List<int>> wrappedSquareMatrix;

            public RotatedMatrix(List<List<int>> squareMatrix)
            {
                wrappedSquareMatrix = squareMatrix;
            }

            public int ReadEntry(int i, int j)
            {
                return wrappedSquareMatrix[wrappedSquareMatrix.Count-1-j][i];
            }

            public void WriteEntry(int i, int j , int value)
            {
                wrappedSquareMatrix[wrappedSquareMatrix.Count-1-j][i] = value;
            }
        }
    }
}