using System;

namespace Elements_of_Programming_Interviews.PrimitiveTypes.ReverseDigits
{
    public class Solution
    {
        public static long ReverseDigits(int number)
        {
             long result = 0;
             long temp = Math.Abs(number);

             while(temp != 0)
             {
                 result *= 10;
                 result += temp % 10;
                 temp /= 10;
             }             

             return number < 0 ? -result : result;
        }
    }
}