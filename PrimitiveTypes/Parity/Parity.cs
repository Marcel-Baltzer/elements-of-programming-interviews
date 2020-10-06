namespace Elements_of_Programming_Interviews.PrimitiveTypes
{
    public class Parity
    {
        public int WithBruteForceFor(int number){
            var result = 0;

            while (number > 0){
                result ^= number & 1;
                number >>= 1;
            }

            return result;
        }


        public int For(int number){
            var result = 0;

            while (number > 0){
                result ^= 1;
                number &= number - 1; // Drops the lowest set bit of number
            }

            return result;
        }
    }
}