namespace Elements_of_Programming_Interviews.Chapter4
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
                number &= number - 1; // Drops the lowest set but of number
            }

            return result;
        }
    }
}