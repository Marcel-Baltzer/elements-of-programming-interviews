using System.Collections.Generic;

namespace Elements_of_Programming_Interviews.Arrays.PermuteArray
{
    public class Solution
    {
        static void Swap<T>(List<T> list, int i, int j)
        {
            T temp;
            temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        public static void ApplyPermutation(List<int> permutation, List<int> array)
        {
            for(int i = 0; i < array.Count; i++)
            {
                // Check if the element at index i has not been moved 
                // by checking if permutation[i] is nonnegative.
                int next = i;

                while(permutation[next] >= 0)
                {
                    Swap<int>(array, i, permutation[next]);
                    int temp = permutation[next];

                    // Subtracts permutation.Count from an entry in permutation to make it negative,
                    // which indicates the corresponding move has been performed.
                    permutation[next] = permutation[next] - permutation.Count;
                    next = temp;
                }
            }

            //Restore permutation.
            for(int i = 0; i < permutation.Count; i++)
            {
                permutation[i] = permutation[i] + permutation.Count;
            }
        }

        public static void ApplyPermutationCyclic(List<int> permutation, List<int> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                //Traverses the cycle to see if i is the minimum element.
                bool isMin = true;
                int j = permutation[i];
                
                while(j != i)
                {
                    if(j < i)
                    {
                        isMin = false;
                        break;
                    }

                    j = permutation[j];
                }

                if(isMin)
                {
                    CyclicPermutation(i, permutation, array);
                }
            }
        }

        private static void CyclicPermutation(int start, List<int> permutation, List<int> array)
        {
            int i = start;
            int temp = array[start];
            do 
            {
                int nextI = permutation[i];
                int nextTemp = array[nextI];
                array[nextI] = temp;
                i = nextI;
                temp = nextTemp;

            } while (i != start);
        }
    }
}