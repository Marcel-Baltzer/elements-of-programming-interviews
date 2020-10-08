using System.Collections.Generic;

namespace Elements_of_Programming_Interviews.Arrays.ArbitraryPrecision
{
    public class Solution
    {
        public static List<int> PlusOne(List<int> number)
        {
            int n = number.Count - 1;
            number[n] = number[n] + 1;

            for (int i = n; i>0 && number[i] == 10; i--)
            {
                number[i] = 0;
                number[i-1] = number[i-1] + 1;
            }

            if(number[0] == 10)
            {
                number[0] = 0;
                number.Insert(0, 1);
            }
            
            return number;
        }
    }
}