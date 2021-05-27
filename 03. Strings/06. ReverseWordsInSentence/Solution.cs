namespace Elements_of_Programming_Interviews._03._Strings._06._ReverseWordsInSentence
{
    public class Solution
    {
        public static void ReverseWords(char[] input)
        {
            // Reverses the whole string first.
            Reverse(input, 0, input.Length);

            int start = 0;
            int end;

            while ((end = Find(input, ' ', start)) != -1)
            {
                // Reverses each word in the string.
                Reverse(input, start, end);
                start = end + 1;    
            }

            // Reverses the last word
            Reverse(input , start, input.Length);
        }

        public static void Reverse(char[] array, int start, int stopIndex)
        {
            if(start >= stopIndex)
            {
                return;
            }

            int last = stopIndex - 1;

            for(int i = start; i <= start + (last - start) / 2; i++)
            {
                char tmp = array[i];
                array[i] = array[last - i + start];
                array[last - i +start] = tmp;
            }
        }

        public static int Find(char[] array, char c, int start)
        {
            for (int i = start; i < array.Length; i++)
            {
                if(array[i] == c)
                {
                    return i;
                }
            }
            
            return -1;
        }
    }
}