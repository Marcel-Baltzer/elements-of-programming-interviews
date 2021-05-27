using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._02._Arrays._19._RotateArray
{
    public class Solution
    {
        public static void RotateMatrix(List<List<int>> squareMatrix)
        {
            int matrixSize = squareMatrix.Count-1;
            
            for(int i = 0; i < (squareMatrix.Count / 2); i++)
            {
                for(int j = i; j < matrixSize -i; j++)
                {
                    // Perform a 4-way exchange.
                    int temp1 = squareMatrix[matrixSize - j][i];
                    int temp2 = squareMatrix[matrixSize - i][matrixSize - j];
                    int temp3 = squareMatrix[j][matrixSize - i];
                    int temp4 = squareMatrix[i][j];

                    squareMatrix[i][j] = temp1;
                    squareMatrix[matrixSize - j][i] = temp2;
                    squareMatrix[matrixSize - i][matrixSize - j] = temp3;
                    squareMatrix[j][matrixSize - i] = temp4;                    
                }
            }
        }

        public class RotatedMatrix
        {
            private List<List<int>> WrappedSquareMatrtix;

            public RotatedMatrix(List<List<int>> squareMatrix)
            {
                this.WrappedSquareMatrtix = squareMatrix;
            }

            public int ReadEntry(int i, int j)
            {
                return WrappedSquareMatrtix[WrappedSquareMatrtix.Count-1-j][i];
            }

            public void WriteEntry(int i, int j , int value)
            {
                WrappedSquareMatrtix[WrappedSquareMatrtix.Count-1-j][i] = value;
            }
        }
    }
}