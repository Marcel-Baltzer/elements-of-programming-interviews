## 17. The Sudoku checker problem

Sudoku is a popular logic-based combinatorial number placement puzzle. The objective is to fill a 9X9 grid with digits subject to the constraint that each column, each row, and each of the nine 3x3 sub-grids that compose the grid contains unique integers in [1,9].

Check whether a 9X9 2D array representing a partially completed Sudoku is valid. Specifically, check that no row, column, or 3X3 2D subarray contains duplicates. A 0-value in the 2D array indicates that entry is blank; every other entry is in [1,9].

>Hint: Directly test the constraints. Use an array to encode sets.