using System.Collections.Generic;
using System.Linq;

namespace Elements_of_Programming_Interviews.Arrays.DutchFlagPartition
{
    public enum Color { RED , WHITE , BLUE };

    public class Solution
    {        
        static void Swap<T>(List<T> list, int i, int j)
        {
            T temp;
            temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        public static void DutchFlagPartitionVariationOne(int pivotIndex, List<Color> colours)
        {
            Color pivot = colours[pivotIndex];
            // First pass: group elements smaller than pivot.
            for(int i = 0; i < colours.Count(); i++)
            {
                // Look for a smaller element.
                for (int j = i + 1; j < colours.Count; ++j){
                    if ((int)colours[j] < (int)pivot)
                    {
                        Swap<Color>(colours , i, j);
                        break;
                    }
                }
            }
            // Second pass: group elements larger than pivot.
            for (int i = colours.Count - 1 ; i >= 0 && (int)colours[i] >= (int)pivot; i--)
            {
                // Look for a larger element. Stop when we reach an element less
                // than pivot, since first pass has moved them to the start of colours
                for(int j = i-1; j >= 0 && (int)colours[j] >= (int)pivot; j--)
                {
                    if((int)colours[j] > (int)pivot)
                    {
                        Swap<Color>(colours, i, j);
                        break;
                    }
                }
            }
        }

        public static void DutchFlagPartitionVariationTwo(int pivotIndex, List<Color> colours)
        {
            Color pivot = colours[pivotIndex];

            // First pass: group elements smaller than pivot.
            int smaller = 0;
            for(int i = 0; i < colours.Count(); i++)
            {
                if((int)colours[i] < (int)pivot)
                {
                    Swap<Color>(colours, i, smaller);
                    smaller++;
                }
            }

            // Second pass: group elements larger than pivot.
            int larger = colours.Count - 1;
            for(int i = colours.Count -1; i >= 0 && (int)colours[i] >= (int)pivot; i--)
            {
                if((int)colours[i] > (int)pivot)
                {
                    Swap<Color>(colours, i, larger);
                    larger--;
                }
            }
        }

        public static void DutchFlagPartitionVariationThree(int pivotIndex, List<Color> colours)
        {
            Color pivot = colours[pivotIndex];
            /*
             * Keep the following invariants during partitioning:
             * bottom group:       colours.subList (0 , smaller).
             * middle group:       colours.subList (smaller , equal).
             * unclassified group: colours.subList (equal , larger).
             * top group:          colours.subList (larger , colours.Count()).
             */

            int smaller = 0;
            int equal = 0;
            int larger = colours.Count();

            // Keep iterating as long as there is an unclassified element
            while (equal < larger)
            {
                // colours[equal] is the incoming unclassified element
                if((int)colours[equal] < (int)pivot)
                {
                    Swap<Color>(colours, smaller, equal);
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
                    Swap<Color>(colours, equal, larger);                    
                }
            }
        }
    }
}