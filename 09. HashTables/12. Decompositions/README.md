## 12. Compute all string decompositions

This problem is concerned with taking a string (the "sentence" string) and a set of strings (the "words"), and finding the substrings of the sentence which are the concatenation of all the words (in any order). For example, if the sentence string is "amanaplanacanal" and the set of words is {"can","apl","ana"), "aplanacan" is a substring of the sentence that is the concatenation of all words.

Write a program which takes as input a string (the "sentence") and an array of strings (the "words"), and returns the starting indices of substrings of the sentence string which are the concatenation of all the strings in the words array. Each string must appear exactly once, and their ordering is immaterial. Assume all strings in the words array have equal length. It is possible for the words array to contain duplicates.

> Hint: Exploit the fact that the words have the same length.
