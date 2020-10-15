## 14. Compute a random permutation

Generating random permutations is not as straightforward as it seems. For example, iterating through (0,1,...,n-1) and swapping each element with another randomly selected element does not generate all permutations with equal probability. One way to see this is to consider the case n = 3. The number of permutations is 3! = 6. The total number of ways in which we can choose the elements to swap is 3<sup>3</sup> = 27 and all are equally likely. Since 27 is not divisible by 6, some permutations correspond to more ways than others,so not all permutations are equally likely.

Design an algorithm that creates uniformly random permutations of (0,1,...,n-1). You are given a random number generator that returns integers in the set(0,1,...,n-1) with equal probability; use as few calls to it as possible.

>Hint: If the result is stored in A, how would you proceed once A[n -1] is assigned correctly?