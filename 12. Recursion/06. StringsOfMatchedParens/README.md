## 6. Generate strings of matched parens

Strings in which parens are matched are defined by the following three rules:
- The empty string, "", is a string in which parens are matched.
- The addition of a leading left parens and a trailing right parens to a string in which parens are matched results in a string in which parens are matched. For example, since "(())()" is a string with matched parens, so is "((())())".
- The concatenation of two strings in which parens are matched is itself a string in which parens are matched. For example, since "(())()" and "()" are strings with matched parens, so is "(())()()".

For example, the set of strings containing two pairs of matched parens
is ( (()), ()() ), and the set of strings with three pairs of matched parens is
( ((())), (()()), (())(), ()(()), ()()() ).

Write a program that takes as input a number and returns all the strings with that number of matched pairs of parens.

> Hint: Think about what the prefix of a string of matched parens must look like.