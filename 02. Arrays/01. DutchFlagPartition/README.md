## 1. The Dutch national flag problem

The quicksort algorithm for sorting arrays proceeds recursively - it selects an element (the "pivot"),reorders the array to make all the elements less than or equal to the pivot appear first, followed by all the elements greater than the pivot. The two subarrays are then sorted recursively.  
Implemented naively, quicksort has large run times and deep function call stacks on arrays with many duplicates because the subarrays may differ greatly in size. One solution is to reorder the array so that all elements less than the pivot appear first, followed by elements equal to the pivot,followed by elements greater than the pivot. This is known as Dutch national flag partitioning, because the Dutch national flag consists of three horizontal bands, each in a different color.

Generalizing,suppose A = (0,l,2,0,2,l,l), and the pivot index is 3. Then A[3] = 0, so (0,0,1,2,2,1,1) is a valid partitioning. For the same array, if the pivot index is 2, then A[2] = 2, so the arrays (0,1,0,1,1,2,2) as well as (0,0,1,1,1,2,2) are valid partitionings.

Write a program that takes an array A and an index i into A, and rearranges the elements such that all elements less than A[i] (the "pivot") appear first, followed by elements equal to the pivot, followed by elements greater than the pivot.

>Hint: Think about the partition step in quicksort.