using System;

namespace Elements_of_Programming_Interviews._01._PrimitiveTypes._09._Palindrome
{
    public class Solution
    {
        public static bool IsPalindromeNumber(int number)
        {
            if(number < 0)
            {
                return false;
            }

            int digitsCount = (int) (Math.Floor(Math.Log10(number))) + 1;
            int mostSignificantDigitMask = (int)Math.Pow(10 , digitsCount - 1);

            for(int i = 0; i < (digitsCount / 2); i++)
            {
                if( number / mostSignificantDigitMask != number % 10)
                {
                    return false;
                }    

                number %= mostSignificantDigitMask;
                number /= 10;
                mostSignificantDigitMask /= 100;                 
            }
            
            return true;
        }

        public static bool IsPalindromeNumberAlternative(int number)
        {
            if(number < 0)
            {
                return false;
            }

            var reverse = _08._ReverseDigits.Solution.ReverseDigits(number);

            return number == reverse;
        }
    }
}