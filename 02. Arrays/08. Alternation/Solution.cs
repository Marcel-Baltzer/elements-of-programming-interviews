using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._02._Arrays._08._Alternation
{
    public class Solution
    {
        public static void Rearrange(List<int> arrays)
        {
            for(int i = 0; i < arrays.Count-2; i++)
            {
                arrays.Sort(i, 3, Comparer<int>.Default);

                if(i%2 == 1)
                {
                    arrays.Reverse(i, 3);
                }
            }
        }
    }
}