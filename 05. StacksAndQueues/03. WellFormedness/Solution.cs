using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._05._StacksAndQueues._03._WellFormedness
{
    public class Solution
    {
        public static bool IsWellFormed(string s)
        {
            var leftChars = new Stack<char>();

            for (var i = 0; i < s.Length; ++i)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    leftChars.Push(s[i]);
                }
                else
                {
                    if (leftChars.Count == 0)
                    {
                        return false; // Unmatched right char.
                    }

                    if ((s[i] == ')' && leftChars.Peek() != '(')
                    || (s[i] == '}' && leftChars.Peek() != '{')
                    || (s[i] == ']' && leftChars.Peek() != '['))
                    {
                        return false; // Mismatched chars.
                    }
                    leftChars.Pop();
                }
            }

            return leftChars.Count == 0;
        }
    }
}