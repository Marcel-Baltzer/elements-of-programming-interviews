using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._08._Searching._06._MatrixSearch
{
    public class Solution
    {
        public static bool MatrixSearch(List<List<int>> array, int x)
        {
            // Start from the top-right corner.
            var row = 0;
            var col = array[0].Count - 1;

            // Keeps searching while there are unclassified rows and columns.
            while (row < array.Count && col >= 0)
            {
                if (array[row][col].Equals(x))
                {
                    return true;
                }
                else if (array[row][col] < x)
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