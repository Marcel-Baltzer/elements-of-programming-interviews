using System;

namespace Elements_of_Programming_Interviews.PrimitiveTypes.UniformRandom
{
    public class Solution
    {
        public static int UniformRandom(int lowerBound, int upperBound)
        {
            var result = 0;
            var numberOfOutcomes = upperBound - lowerBound + 1;            

            do
            {
                for (int i = 0; (1 << i) < numberOfOutcomes; i++)
                {
                    Random random = new Random();
                    int randomNumber = random.Next(0, 2);
                    
                    result = (result << 1) | randomNumber;
                }

            } while (result >= numberOfOutcomes); 

            return result + lowerBound;
        }
    }
}