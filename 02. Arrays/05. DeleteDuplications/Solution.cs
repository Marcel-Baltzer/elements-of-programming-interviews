using System.Collections.Generic;
using System.Linq;

namespace Elements_of_Programming_Interviews.Arrays.DeleteDuplications
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

            int writeIndex = 1;

            for(int i = 1; i < sortedArray.Count; i++)
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