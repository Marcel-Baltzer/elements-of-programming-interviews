using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._02._Arrays._10._PermuteArray
{
    public class Solution
    {
        private static void Swap<T>(IList<T> list, int i, int j)
        {
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        public static void ApplyPermutation(List<int> permutation, List<int> array)
        {
            for(var i = 0; i < array.Count; i++)
            {
                // Check if the element at index i has not been moved 
                // by checking if permutation[i] is nonnegative.
                var next = i;

                while(permutation[next] >= 0)
                {
                    Swap(array, i, permutation[next]);
                    var temp = permutation[next];

                    // Subtracts permutation.Count from an entry in permutation to make it negative,
                    // which indicates the corresponding move has been performed.
                    permutation[next] = permutation[next] - permutation.Count;
                    next = temp;
                }
            }

            //Restore permutation.
            for(var i = 0; i < permutation.Count; i++)
            {
                permutation[i] = permutation[i] + permutation.Count;
            }
        }

        public static void ApplyPermutationCyclic(List<int> permutation, List<int> array)
        {
            for (var i = 0; i < array.Count; i++)
            {
                //Traverses the cycle to see if i is the minimum element.
                var isMin = true;
                var j = permutation[i];
                
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
            var i = start;
            var temp = array[start];
            do 
            {
                var nextI = permutation[i];
                var nextTemp = array[nextI];
                array[nextI] = temp;
                i = nextI;
                temp = nextTemp;

            } while (i != start);
        }
    }
}