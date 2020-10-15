## 18. Compute the spiral ordering of a 2D array

A 2D array can be written as a sequence in several orders - the most natural ones being row-by-row or column-by-column. In this problem we explore the problem of writing the 2D array in spiral order. For example, the spiral ordering for the 2D
array A[3][3] = {{1,2,3},{4,5,6},{7,8,9}} is (1,2,3,6,9,8,7,4,5). For B[4][4] = {{1,2,3,4},{5,6,7,8},{9,10,11,12},{,13,14,15,16}}, the spiral ordering is (1,2,3,4,8,12,16,15,14,13,9,5,6,7,11,10).

Write a program which takes an nXn 2D array and returns the spiral ordering of the array.

>Hint: Use case analysis and divide-and-conquer.