## 5. Compute x*y without arithmetical operators

Sometimes the processors used in ultra low-power devices such as hearing aids do
not have dedicated hardware for performing multiplication. A program that needs
to perform multiplication must do so explicitly using lower-level primitives.

Write a program that multiplies two nonnegative integers.   
The only operators you are allowed to use are  
- assignment,  
- the bitwise operators », «, |, &, “ and  
- equality checks and Boolean combinations thereof.

You may use loops and functions that you write yourself. These constraints imply,
for example, that you cannot use increment or decrement, or test if x < y.

>Hint: Add using bitwise operations; multiply using shift-and-add.