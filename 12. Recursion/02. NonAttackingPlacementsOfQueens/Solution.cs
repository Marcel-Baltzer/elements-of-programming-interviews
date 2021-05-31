using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._12._Recursion._02._NonAttackingPlacementsOfQueens
{
    public static class Solution
    {
        public static List<List<int>> NQueens(int n)
        {
            var result = new List<List<int>>();
            SolveNQueens(n, 0, new List<int>(), result);
            return result;
        }

        private static void SolveNQueens(int n, int row, List<int> colPlacement, List<List<int>> result)
        {
            if (row == n)
            {
                // All queens are legally placed.
                result.Add(new List<int>(colPlacement));
            }
            else
            {
                for (var col = 0; col < n; col++)
                {
                    colPlacement.Add(col);
                    if (IsValid(colPlacement))
                    {
                        SolveNQueens(n, row +1, colPlacement, result);
                    }

                    colPlacement.RemoveAt(colPlacement.Count - 1);
                }
            }
        }
        
        // Test if a newly placed queen will conflict any earlier queens
        // placed before.
        private static bool IsValid(IReadOnlyList<int> colPlacement)
        {
            var rowId = colPlacement.Count - 1;
            for (var i = 0; i < rowId; i++)
            {
                var diff = Math.Abs(colPlacement[i] - colPlacement[rowId]);
                if (diff == 0 || diff == rowId - i)
                {
                    return false;
                }
            }

            return true;
        }
    }
}