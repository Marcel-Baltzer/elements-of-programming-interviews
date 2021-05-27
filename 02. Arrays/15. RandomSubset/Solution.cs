using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._02._Arrays._15._RandomSubset
{
    public class Solution
    {
        public static List<int> RandomSubset(int size, int subSize)
        {
            var changedElements = new Dictionary<int,int>();
            var randIdxGen = new Random();

            for(var i = 0; i < subSize; i++)
            {
                // Generate random int in [i, n - 1].
                var randIdx = i + randIdxGen.Next(size - i);
                var ptr1Exist = changedElements.TryGetValue(randIdx, out var ptr1);
                var ptr2Exist = changedElements.TryGetValue(i, out var ptr2);

                if(!ptr1Exist && !ptr2Exist)
                {
                    changedElements[randIdx] = i;
                    changedElements[i] = randIdx;
                }
                else if(!ptr1Exist) // ptr2Exist always true
                {
                    changedElements[randIdx] = ptr2;
                    changedElements[i] = randIdx;
                }
                else if(!ptr2Exist) // ptr1Exist always true
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

            for(var i = 0; i < subSize; i++)
            {
                result.Add(changedElements[i]);
            }

            return result;
        }
    }
}