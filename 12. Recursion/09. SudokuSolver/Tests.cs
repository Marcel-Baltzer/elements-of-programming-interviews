using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._12._Recursion._09._SudokuSolver
{
    public class Tests
    {
        [Fact]
        public void SolveSudoku()
        {
            var sudoku = new List<List<int>>
            {
                new() {5, 0, 4, 0, 7, 0, 9, 0, 0},
                new() {0, 0, 0, 0, 0, 0, 0, 4, 0},
                new() {0, 0, 8, 3, 0, 2, 0, 6, 7},
                new() {8, 0, 9, 0, 0, 0, 0, 0, 3},
                new() {0, 2, 0, 0, 0, 0, 0, 9, 0},
                new() {0, 0, 0, 0, 0, 0, 8, 0, 0},
                new() {9, 0, 0, 0, 0, 0, 0, 8, 0},
                new() {2, 0, 0, 4, 1, 9, 0, 3, 0},
                new() {3, 0, 0, 0, 0, 0, 0, 7, 0}
            };

            var result = Solution.SolveSudoku(sudoku);

            result.Should().BeTrue();
        }
    }
}