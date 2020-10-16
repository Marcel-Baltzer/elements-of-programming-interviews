## 8. The look-and-say problem

The look-and-say sequence starts with 1. Subsequent numbers are derived by describing the previous number in terms of consecutive digits. Specifically, to generate an entry of the sequence from the previous entry, read off the digits of the previous entry, counting the number of digits in groups of the same digit. For example, 1; one 1; two 1s; one 2 then one 1; one 1, then one 2, then two 1s; three 1s, then two 2s, then one 1. The first eight numbers in the look-and-say sequence are <1,11,21,1211,111221,312211,13112221,1113213211>.

Write a program that takes as input an integer n and returns the nth integer in the look-and-say sequence. Return the result as a string.

>Hint: You need to return the result as a string.