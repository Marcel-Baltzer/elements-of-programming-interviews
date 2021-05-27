using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._02._Arrays._13._SampleOnlineData
{
    public class Solution
    {
        public static List<int> OnlineRandomSample(IEnumerator<int> sequence, int size)
        {
            var runningSample = new List<int>(size);

            for(var i = 0; sequence.MoveNext() && i < size; i++)
            {
                runningSample.Add(sequence.Current);
            }

            // Have read the first k elements.
            var numSeenSoFar = size;
            var randIdxGen = new Random();

            while(sequence.MoveNext())
            {
                var x = sequence.Current;
                numSeenSoFar++;
                // Generate a random number in [0, numSeenSoFar], and if this number is in
                // [0, size - 1], we replace that element from the sample with x.
                var idxToReplace = randIdxGen.Next(numSeenSoFar);
                if(idxToReplace < size)
                {
                    runningSample[idxToReplace] = x;
                }
            }

            return runningSample;
        }
    }
}