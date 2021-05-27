using System;
using System.Collections.Generic;
using System.Linq;

namespace Elements_of_Programming_Interviews._02._Arrays._03._ArbitraryPrecisionMultiply
{
    public class Solution
    {
        public static List<int> Multiply(List<int> numberOne, List<int> numberTwo)
        {
            var sign = numberOne[0] < 0 || numberTwo[0] < 0 ? -1 : 1;

            numberOne[0] = Math.Abs(numberOne[0]);
            numberTwo[0] = Math.Abs(numberTwo[0]);
            
            var result = new List<int>(new int[numberOne.Count + numberTwo.Count]);
        
            for(var i = numberOne.Count -1; i >= 0; i--)
            {
                for(var j = numberTwo.Count -1; j >= 0; j--)
                {
                    result[i+j+1] = result[i+j+1] + numberOne[i] * numberTwo[j];
                    result[i+j] = result[i+j] + result[i+j+1] / 10;
                    result[i+j+1] = result[i+j+1] % 10;
                }
            }

            // Remove the leading zeroes.
            var firstNotZero = 0;
            while (firstNotZero < result.Count && result[firstNotZero] == 0) 
            {
                firstNotZero++;
            }

            result = result.GetRange(firstNotZero, result.Count - firstNotZero);

            if(!result.Any())
            {
                return new List<int>() {0};
            }

            result[0] = result[0] * sign;
            return result;            
        }
    }
}