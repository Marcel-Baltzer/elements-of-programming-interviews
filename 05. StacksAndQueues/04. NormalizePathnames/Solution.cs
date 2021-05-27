using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elements_of_Programming_Interviews._05._StacksAndQueues._04._NormalizePathnames
{
    public class Solution
    {
        public static string ShortestEquivalentPath(string path)
        {
            if (path.Equals(""))
            {
                throw new InvalidOperationException("Empty string is not a legal path.");
            }

            var pathNames = new Stack<string>();

            // Special case: starts with "/", which is an absolute path.
            if (path.StartsWith("/"))
            {
                pathNames.Push("/");
            }

            foreach (var token in path.Split("/"))
            {
                if (token.Equals(".."))
                {
                    if (pathNames.Count == 0 || pathNames.Peek().Equals(".."))
                    {
                        pathNames.Push(token);
                    }
                    else
                    {
                        if (pathNames.Peek().Equals("/"))
                        {
                            throw new InvalidOperationException($"Path error, trying to go up root {path}.");
                        }

                        pathNames.Pop();
                    }
                }
                else if (!token.Equals(".") && token.Length > 0) // Must be a name.
                {
                    pathNames.Push(token);
                }
            }

            var result = new StringBuilder();

            if (pathNames.Count > 0)
            {
                using var enu = pathNames.OrderByDescending(x => x).GetEnumerator();

                enu.MoveNext();
                var prev = enu.Current;
                result.Append(prev);

                while (enu.MoveNext())
                {
                    if (prev != null && !prev.Equals("/"))
                    {
                        result.Append('/');
                    }

                    prev = enu.Current;
                    result.Append(prev);
                }
            }

            return result.ToString();
        }
    }
}