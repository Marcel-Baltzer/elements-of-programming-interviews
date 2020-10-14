using System;
using System.Linq;
using System.Text;

namespace Elements_of_Programming_Interviews.Strings.InterconvertStringsAndIntegers
{
    public class Solution
    {
        public static string IntToString(int x)
        {
            bool isNegative = false;

            if(x < 0)
            {
                isNegative = true;
            }

            StringBuilder s = new StringBuilder();

            do 
            {
                s.Append((char)('0' + Math.Abs(x % 10)));
                x /= 10;

            } while (x != 0);

            if(isNegative)
            {
                s.Append('-'); // Adds the negative sign back.
            }

            char[] charArray = s.ToString().ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static int StringToInt(string s)
        {
            int result = 0;
            for(int i = s[0] == '-' ? 1 : 0; i < s.Length; i++)
            {
                int digit = s[i] - '0';
                result = result * 10 + digit;
            }

            return s[0] == '-' ? -result : result;
        }
    }
}