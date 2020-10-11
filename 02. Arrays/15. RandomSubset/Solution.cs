using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews.Arrays.RandomSubset
{
    public class Solution
    {
        public static List<int> RandomSubset(int size, int subSize)
        {
            var changedElements = new Dictionary<int,int>();
            var randldxGen = new Random();

            for(int i = 0; i < subSize; i++)
            {
                // Generate random int in [i, n - 1].
                int randIdx = i + randldxGen.Next(size - i);
                int ptr1;
                int ptr2;   
                var ptr1Exist = changedElements.TryGetValue(randIdx, out ptr1);
                var ptr2Exist = changedElements.TryGetValue(i, out ptr2);

                if(!ptr1Exist && !ptr2Exist)
                {
                    changedElements[randIdx] = i;
                    changedElements[i] = randIdx;
                }
                else if(!ptr1Exist && ptr2Exist)
                {
                    changedElements[randIdx] = ptr2;
                    changedElements[i] = randIdx;
                }
                else if(ptr1Exist && !ptr2Exist)
                {
                    changedElements[i] = ptr1;
                    changedElements[randIdx] = i;
                }
                else
                {
                    changedElements[i] = ptr1;
                    changedElements[randIdx] = ptr2;
                }
            }

            var result = new List<int>(subSize);

            for(int i = 0; i < subSize; i++)
            {
                result.Add(changedElements[i]);
            }

            return result;
        }
    }
}