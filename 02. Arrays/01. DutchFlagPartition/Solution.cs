using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._02._Arrays._01._DutchFlagPartition
{
    public enum Color { Red , White , Blue };

    public class Solution
    {
        private static void Swap<T>(IList<T> list, int i, int j)
        {
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        public static void DutchFlagPartitionVariationOne(int pivotIndex, List<Color> colours)
        {
            var pivot = colours[pivotIndex];
            // First pass: group elements smaller than pivot.
            for(var i = 0; i < colours.Count; i++)
            {
                // Look for a smaller element.
                for (var j = i + 1; j < colours.Count; ++j){
                    if ((int)colours[j] < (int)pivot)
                    {
                        Swap(colours , i, j);
                        break;
                    }
                }
            }
            // Second pass: group elements larger than pivot.
            for (var i = colours.Count - 1 ; i >= 0 && (int)colours[i] >= (int)pivot; i--)
            {
                // Look for a larger element. Stop when we reach an element less
                // than pivot, since first pass has moved them to the start of colours
                for(var j = i-1; j >= 0 && (int)colours[j] >= (int)pivot; j--)
                {
                    if((int)colours[j] > (int)pivot)
                    {
                        Swap(colours, i, j);
                        break;
                    }
                }
            }
        }

        public static void DutchFlagPartitionVariationTwo(int pivotIndex, List<Color> colours)
        {
            var pivot = colours[pivotIndex];

            // First pass: group elements smaller than pivot.
            var smaller = 0;
            for(var i = 0; i < colours.Count; i++)
            {
                if((int)colours[i] < (int)pivot)
                {
                    Swap(colours, i, smaller);
                    smaller++;
                }
            }

            // Second pass: group elements larger than pivot.
            var larger = colours.Count - 1;
            for(var i = colours.Count -1; i >= 0 && (int)colours[i] >= (int)pivot; i--)
            {
                if((int)colours[i] > (int)pivot)
                {
                    Swap(colours, i, larger);
                    larger--;
                }
            }
        }

        public static void DutchFlagPartitionVariationThree(int pivotIndex, List<Color> colours)
        {
            var pivot = colours[pivotIndex];
            /*
             * Keep the following invariants during partitioning:
             * bottom group:       colours.subList (0 , smaller).
             * middle group:       colours.subList (smaller , equal).
             * unclassified group: colours.subList (equal , larger).
             * top group:          colours.subList (larger , colours.Count()).
             */

            var smaller = 0;
            var equal = 0;
            var larger = colours.Count;

            // Keep iterating as long as there is an unclassified element
            while (equal < larger)
            {
                // colours[equal] is the incoming unclassified element
                if((int)colours[equal] < (int)pivot)
                {
                    Swap(colours, smaller, equal);
                    smaller++;
                    equal++;
                }
                else if((int)colours[equal] == (int)pivot)
                {
                    equal++;
                }
                else // colours[equal] > pivot
                {
                    larger--;
                    Swap(colours, equal, larger);                    
                }
            }
        }
    }
}