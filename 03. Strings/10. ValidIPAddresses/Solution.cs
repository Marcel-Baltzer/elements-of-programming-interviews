using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._03._Strings._10._ValidIPAddresses
{
    public class Solution
    {
        public static List<string> GetValidIpAddress(string s)
        {
            List<string> result = new List<string>();

            for(int i = 1; i < 4 && i < s.Length; i++)
            {
                string first = s.Substring(0,i);

                if(IsValidPart(first))
                {
                    for(int j = 1; i+j < s.Length && j < 4; j++)
                    {
                        string second = s.Substring(i, j);
                        if(IsValidPart(second))
                        {
                            for(int k = 1; i+j+k < s.Length && k < 4; k++)
                            {
                                string third = s.Substring(i+j,k);
                                string fourth = s.Substring(i+j+k);

                                if(IsValidPart(third) && IsValidPart(fourth))
                                {
                                    result.Add(first + "." + second + "." + third + "." + fourth);
                                }
                            }
                        }                        
                    }
                }
            }

            return result;
        }

        private static bool IsValidPart(string s)
        {
            if(s.Length > 3)
            {
                return false;
            }

            if(s.StartsWith("0") && s.Length > 1)
            {
                return false;
            }

            int val = int.Parse(s);
            return 0 <= val && val <= 255;
        }
    }
}