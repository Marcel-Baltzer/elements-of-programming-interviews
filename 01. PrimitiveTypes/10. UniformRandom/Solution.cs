using System;

namespace Elements_of_Programming_Interviews._01._PrimitiveTypes._10._UniformRandom
{
    public class Solution
    {
        public static int UniformRandom(int lowerBound, int upperBound)
        {
            var result = 0;
            var numberOfOutcomes = upperBound - lowerBound + 1;            

            do
            {
                for (var i = 0; (1 << i) < numberOfOutcomes; i++)
                {
                    var random = new Random();
                    var randomNumber = random.Next(0, 2);
                    
                    result = (result << 1) | randomNumber;
                }

            } while (result >= numberOfOutcomes); 

            return result + lowerBound;
        }
    }
}