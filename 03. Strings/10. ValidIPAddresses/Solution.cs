using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._03._Strings._10._ValidIPAddresses
{
    public class Solution
    {
        public static List<string> GetValidIpAddress(string s)
        {
            var result = new List<string>();

            for(var i = 1; i < 4 && i < s.Length; i++)
            {
                var first = s.Substring(0,i);

                if(IsValidPart(first))
                {
                    for(var j = 1; i+j < s.Length && j < 4; j++)
                    {
                        var second = s.Substring(i, j);
                        if(IsValidPart(second))
                        {
                            for(var k = 1; i+j+k < s.Length && k < 4; k++)
                            {
                                var third = s.Substring(i+j,k);
                                var fourth = s.Substring(i+j+k);

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

            var val = int.Parse(s);
            return 0 <= val && val <= 255;
        }
    }
}