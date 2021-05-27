namespace Elements_of_Programming_Interviews._03._Strings._04._ReplaceAndRemove
{
    public class Solution
    {
        public static int ReplaceAndRemove(int size, char[] s)
        {
            // Forward iteration: remove "b"s and count the number of "a"s.
            int writeIdx = 0;
            int aCount = 0;

            for (int i = 0; i < size; i++)
            {
                if(s[i] != 'b')
                {
                    s[writeIdx++] = s[i];
                }
                if(s[i] == 'a')
                {
                    aCount++;
                }
            }

            // Backward iteration: replace "a"s with "dd"s starting from the end
            int curIdx = writeIdx -1;
            writeIdx = writeIdx + aCount -1;

            int finalSize = writeIdx +1;
            while(curIdx >= 0)
            {
                if(s[curIdx] == 'a')
                {
                    s[writeIdx--] = 'd';
                    s[writeIdx--] = 'd';
                }
                else
                {
                    s[writeIdx--] = s[curIdx];
                }
                curIdx--;
            }

            return finalSize;
        }
    }
}