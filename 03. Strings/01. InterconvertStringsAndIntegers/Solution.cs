using System;
using System.Text;

namespace Elements_of_Programming_Interviews._03._Strings._01._InterconvertStringsAndIntegers
{
    public class Solution
    {
        public static string IntToString(int x)
        {
            var isNegative = x < 0;

            var s = new StringBuilder();

            do 
            {
                s.Append((char)('0' + Math.Abs(x % 10)));
                x /= 10;

            } while (x != 0);

            if(isNegative)
            {
                s.Append('-'); // Adds the negative sign back.
            }

            var charArray = s.ToString().ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static int StringToInt(string s)
        {
            var result = 0;
            for(var i = s[0] == '-' ? 1 : 0; i < s.Length; i++)
            {
                var digit = s[i] - '0';
                result = result * 10 + digit;
            }

            return s[0] == '-' ? -result : result;
        }
    }
}