using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Arrays.SudokuChecker
{
    public class Tests
    {
        [Fact]
        public void IsValidSudoku()
        {
            var sodoku = new List<List<int>>
            {
                new List<int> {5,3,4, 6,7,8, 9,1,2},
                new List<int> {6,7,2, 1,9,5, 3,4,8},
                new List<int> {1,9,8, 3,4,2, 5,6,7},
                
                new List<int> {8,5,9, 7,6,1, 4,2,3},
                new List<int> {4,2,6, 8,5,3, 7,9,1},
                new List<int> {7,1,3, 9,2,4, 8,5,6},
                
                new List<int> {9,6,1, 5,3,7, 2,8,4},
                new List<int> {2,8,7, 4,1,9, 6,3,5},
                new List<int> {3,4,5, 2,8,6, 1,7,9}
            };

            var result = Solution.IsValidSudoku(sodoku);

            result.Should().BeTrue();
        }
    }
}