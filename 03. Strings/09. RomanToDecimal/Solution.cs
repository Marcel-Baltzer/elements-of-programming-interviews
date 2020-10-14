using System.Collections.Generic;

namespace Elements_of_Programming_Interviews.Strings.RomanToDecimal
{
    public class Solution
    {
        public static int RomanToInterger(string romanString)
        {
            var romanValues = new Dictionary<char,int>()
            {
                {'I',1},
                {'V',5},
                {'X',10},
                {'L',50},
                {'C',100},
                {'D',500},
                {'M',1000},
            };

            int sum = romanValues[romanString[romanString.Length-1]];

            for (int i = romanString.Length -2; i >= 0; i--)
            {
                if(romanValues[romanString[i]] < romanValues[romanString[i+1]])
                {
                    sum -= romanValues[romanString[i]];
                }
                else
                {
                    sum += romanValues[romanString[i]];
                }
            }

            return sum;
        }
    }
}