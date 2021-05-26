using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._10._Sorting._04._NonConstructibleValue
{
    public class Solution
    {
        public static int SmallestNonConstructibleValue(List<int> list)
        {
            var maxConstructibleValue = 0;
            
            list.Sort();

            foreach (var value in list)
            {
                if (value > maxConstructibleValue + 1)
                {
                    break;
                }

                maxConstructibleValue += value;
            }

            return maxConstructibleValue + 1;
        }
    }
}