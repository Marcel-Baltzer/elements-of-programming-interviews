namespace Elements_of_Programming_Interviews._02._Arrays._00._BootCamp
{
    public class Solution
    {
        public static void EvenOdd(int[] array)
        {
            var nextEven = 0;
            var nextOdd = array.Length -1;

            while (nextEven < nextOdd)
            {
                if(array[nextEven] % 2 == 0)
                {
                    nextEven++;
                } 
                else
                {
                    var temp = array[nextEven];
                    array[nextEven] = array[nextOdd];
                    array[nextOdd] = temp;
                    nextOdd--;
                }
            }
        }
    }
}