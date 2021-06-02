using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._12._Recursion._09._SudokuSolver
{
    public static class Solution
    {
        private const int EmptyEntry = 0;

        public static bool SolveSudoku(List<List<int>> partialAssignment)
        {
            return SolvePartialSudoku(0, 0, partialAssignment);
        }

        private static bool SolvePartialSudoku(int i, int j, IReadOnlyList<List<int>> partialAssignment)
        {
            if (i == partialAssignment.Count)
            {
                i = 0; //Starts a new Row.
                if (++j == partialAssignment[i].Count)
                {
                    // Entire matrix has been filled without conflict.
                    return true;
                }
            }

            // Skips nonempty entries.
            if (partialAssignment[i][j] != EmptyEntry)
            {
                return SolvePartialSudoku(i + 1, j, partialAssignment);
            }

            for (var value = 1; value <= partialAssignment.Count; value++)
            {
                // It’s substantially quicker to check if entry val conflicts
                // with any of the constraints if we add it at (i,j) before
                // adding it, rather than adding it and then checking all constraints.
                // The reason is that we are starting with a valid configuration,
                // and the only entry which can cause a problem is entry value at (i,j).
                if (ValidToAddValue(partialAssignment, i, j, value))
                {
                    partialAssignment[i][j] = value;
                    if (SolvePartialSudoku(i + 1, j, partialAssignment))
                    {
                        return true;
                    }
                }
            }

            partialAssignment[i][j] = EmptyEntry; // Undo assignment.
            return false;
        }

        private static bool ValidToAddValue(IReadOnlyList<List<int>> partialAssignment, int i, int j, int value)
        {
            // Check row constraints.
            foreach (var element in partialAssignment)
            {
                if (value == element[j])
                {
                    return false;
                }
            }

            // Check column constraints.
            foreach (var element in partialAssignment[i])
            {
                if (value == element)
                {
                    return false;
                }
            }

            // Check region constraints.
            var regionSize = (int) Math.Sqrt(partialAssignment.Count);
            i /= regionSize;
            j /= regionSize;
            for (var a = 0; a < regionSize; a++)
            {
                for (var b = 0; b < regionSize; b++)
                {
                    if (value == partialAssignment[regionSize * i + a][regionSize * j + b])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}