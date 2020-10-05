namespace Elements_of_Programming_Interviews.Chapter4
{
    public class CountBits{

        public int For(int number){
            
            var num_bits = 0;

            while (number > 0){
                num_bits += number & 1;
                number >>= 1;
            }

            return num_bits;
        }
    }
}