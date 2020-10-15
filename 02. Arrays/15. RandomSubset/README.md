## 15. Compute a random subset

The set (0,1, 2,...,n-1) has n!/((n - k)!k!) subsets of size k. We seek to design an algorithm that returns any one of these subsets with equal probability.

Write a program that takes as input a positive integer n and a size k < n, and returns a size-k subset of (0,1,2,...,n-1). The subset should be represented as an array. All subsets should be equally likely and, in addition, all permutations of elements of the array should be equally likely. You may assume you have a function which takes as input a nonnegative integer t and returns an integer in the set (0,1,...,t-1) with uniform probability.

>Hint: Simulate Solution in 12, using an appropriate data structure to reduce space.