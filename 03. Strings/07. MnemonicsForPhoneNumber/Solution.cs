using System.Collections.Generic;

namespace Elements_of_Programming_Interviews.Strings.MnemonicsForPhoneNumber
{
    public class Solution
    {   
        public static List<string> PhoneMnemonic(string phoneNumber)
        {
            var partialMnemonic = new char[phoneNumber.Length];
            var mnemonics = new List<string>();

            PhoneMnemonicHelper(phoneNumber, 0 , partialMnemonic, mnemonics);

            return mnemonics;
        }

        private static string[] Mapping = {"0", "1", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ"};

        private static void PhoneMnemonicHelper(string phoneNumber, int digit, char[] partialMnemonic, List<string> mnemonics)
        {
            if (digit == phoneNumber.Length)
            {
                // All digits are processed, so add partialMnemonic to mnemonics.
                // (We add a copy since subsequent calls modify partialMnemonic.)
                mnemonics.Add(new string(partialMnemonic));
            }
            else
            {
                // Try all possible characters for this digit.
                for (int i = 0; i < Mapping[phoneNumber[digit]-'0'].Length; i++)
                {
                    char c = Mapping[phoneNumber[digit]-'0'][i];
                    partialMnemonic[digit] = c;
                    PhoneMnemonicHelper(phoneNumber, digit +1, partialMnemonic, mnemonics);
                }
            }
        }        
    }
}