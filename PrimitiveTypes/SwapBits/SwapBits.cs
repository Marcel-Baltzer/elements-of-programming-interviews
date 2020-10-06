namespace Elements_of_Programming_Interviews.PrimitiveTypes.SwapBits
{
    public class SwapBits
    {
        public long For(long number, int i, int j){

            if( ((number >> i) & 1) != ((number >> j) & 1) )
            {
                long bitMask = (1L << i) | (1L << j);
                number ^= bitMask;
            }

            return number;
        }
    }
}