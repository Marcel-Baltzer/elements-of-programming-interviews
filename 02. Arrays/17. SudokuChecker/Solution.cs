using System;
using System.Collections.Generic;
using System.Linq;

namespace Elements_of_Programming_Interviews.Arrays.SudokuChecker
{
    public class Solution
    {
        // Check if a partially filled matrix has any conflicts.
        public static bool IsValidSudoku(List<List<int>> partialAssigment)
        {
            // Check row constraints.
            for(int row = 0; row < partialAssigment.Count; row++)
            {
                if(HasDuplicate(partialAssigment, row, row+1, 0, partialAssigment.Count))
                {
                    return false;
                }
            }

            // Check column constraints.
            for(int column = 0; column < partialAssigment.Count; column++)
            {
                if(HasDuplicate(partialAssigment, 0, partialAssigment.Count, column, column+1))
                {
                    return false;
                }
            }

            // Check region constraints.
            int regionSize = (int)Math.Sqrt(partialAssigment.Count);
            for (int row = 0; row < regionSize; row++)
            {
                for(int column = 0; column < regionSize; column++)
                {
                    if(HasDuplicate(partialAssigment, regionSize * row, regionSize * (row +1), regionSize * column, regionSize * (column+1)))
                    {
                        return false;
                    }
                }
            }
            
            return true;
        }

        // Return true if subarray partialAssignment[startRow:endRow - 1][startCol:endCol - 1]
        // contains any duplicates in {1, 2, ..., partialAssignment.Count}; otherwise return false.
        private static bool HasDuplicate(List<List<int>> partialAssigment, int startRow, int endRow, int startCol, int endCol)
        {
            List<bool> isPresent = Enumerable.Repeat(false, partialAssigment.Count+1).ToList();;

            for(int i = startRow; i < endRow; i++)
            {
                for(int j = startCol; j < endCol; j++)
                {
                    if(partialAssigment[i][j] != 0 && isPresent[partialAssigment[i][j]])
                    {
                        return true;
                    }

                    isPresent[partialAssigment[i][j]] = true;
                }
            }

            return false;
        }
    }



}