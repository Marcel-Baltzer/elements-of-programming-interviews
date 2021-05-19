using System.Collections.Generic;

namespace Elements_of_Programming_Interviews.Searching.MatrixSearch
{
    public class Solution
    {
        public static bool MatrixSearch(List<List<int>> A, int x)
        {
            // Start from the top-right corner.
            int row = 0;
            int col = A[0].Count - 1;

            // Keeps searching while there are unclassified rows and columns.
            while (row < A.Count && col >= 0)
            {
                if (A[row][col].Equals(x))
                {
                    return true;
                }
                else if (A[row][col] < x)
                {
                    row++; // Eliminate this row.
                }
                else // A[row][col] > x.
                {
                    col--; // Eliminate this column.
                }
            }
            return false;
        }
    }
}