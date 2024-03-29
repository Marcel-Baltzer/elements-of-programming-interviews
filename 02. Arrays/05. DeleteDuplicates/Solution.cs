using System.Collections.Generic;
using System.Linq;

namespace Elements_of_Programming_Interviews._02._Arrays._05._DeleteDuplicates
{
    public class Solution
    {
        // Returns the number of valid entries after deletion.
        public static int DeleteDuplicates(List<int> sortedArray)
        {
            if(!sortedArray.Any())
            {
                return 0;
            }

            var writeIndex = 1;

            for(var i = 1; i < sortedArray.Count; i++)
            {
                if(!sortedArray[writeIndex-1].Equals(sortedArray[i]))
                {
                    sortedArray[writeIndex] = sortedArray[i];
                    writeIndex++;
                }
            }

            return writeIndex;
        }
    }
}