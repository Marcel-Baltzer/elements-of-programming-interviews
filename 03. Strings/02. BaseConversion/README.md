## 2. Base conversion

In the decimal number system, the position of a digit is used to signify the power of 10 that digit is to be multiplied with. For example, "314" denotes the number 3x100 + 1x10 + 4x1. The base b number system generalizes the decimal number system: the string "a<sub>k-1</sub>a<sub>k-2</sub>...a<sub>1</sub>a<sub>0</sub>" , where 0 <= a<sub>i</sub>, <= b, denotes in base-b the integer a<sub>0</sub> x b<sup>0</sup> + a<sub>1</sub> x b<sup>1</sup> + a<sub>2</sub> x b<sup>2</sup> + ... + a<sub>k-1</sub> x b<sup>k-1</sup>.

Write a program that performs base conversion. The input is a string, an integer b<sub>1</sub>, and another integer b<sub>2</sub>. The string represents be an integer in base b<sub>1</sub>. The output should be the string representing the integer in base b<sub>2</sub>. Assume 2 <= b<sub>1</sub>,b<sub>2</sub> <= 16. Use "A" to represent 10, "B" for 11,..., and "F" for 15. (For example, if the string is "615", b<sub>1</sub> is 7 and b<sub>2</sub> is 13, then the result should be "1A7", since 6x7<sup>2</sup> + 1x7 + 5 = 1x13<sup>2</sup>+ 10x13 + 7.)

>Hint: What base can you easily convert to and from?