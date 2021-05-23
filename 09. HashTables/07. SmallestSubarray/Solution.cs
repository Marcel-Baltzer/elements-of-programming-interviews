
using System.Collections.Generic;
using System.Linq;

namespace Elements_of_Programming_Interviews.HashTables.SmallestSubarray
{
    public class Solution
    {
        // Represent subarray by starting and ending indices, inclusive.
        public class Subarray {
            
            public int Start;
            public int End;
            
            public Subarray(int start, int end) {
                this.Start = start ;
                this.End = end;
            }
        }
        
        
        // Solution One
        public static Subarray FindSmallestSubarrayCoveringSet(List<string> paragraph, HashSet<string> keywords)
        {
            var keywordsToCover = new Dictionary<string, int>();
            
            foreach (var keyword in keywords)
            {
                keywordsToCover[keyword] = keywordsToCover.ContainsKey(keyword) ? keywordsToCover[keyword] + 1 : 1;
            }

            var result = new Subarray(-1, -1);
            var remainingToCover = keywords.Count;

            var left = 0;
            for (var right = 0; right < paragraph.Count; ++right)
            {
               
                
                if (keywordsToCover.ContainsKey(paragraph[right]))
                {
                    var keywordCount = keywordsToCover[paragraph[right]];
                    
                    keywordsToCover[paragraph[right]] = --keywordCount;
                    if (keywordCount >= 0)
                    {
                        --remainingToCover;
                    }
                }
                
                // Keeps advancing left until it reaches end or keywordsToCover does not
                // have all keywords.
                while (remainingToCover == 0)
                {
                    if ((result.Start == -1 && result.End == -1)
                        || right - left < result.End - result.Start)
                    {
                        result.Start = left;
                        result.End = right;
                    }
                    
                    if (keywordsToCover.ContainsKey(paragraph[left]))
                    {
                        var keywordCount = keywordsToCover[paragraph[left]];
                    
                        keywordsToCover[paragraph[left]] = ++keywordCount;
                        if (keywordCount >= 0)
                        {
                            ++remainingToCover;
                        }
                    }
                    ++left;
                }
            }

            return result;
        }
        
        // Solution Two
        public static Subarray FindSmallestSubarrayCoveringSubset(IEnumerator<string> iter, List<string> queryStrings)
        {
            var dict = new Dictionary<string, int>();

            foreach (var s in queryStrings)
            {
                dict[s] = int.MinValue;
            }

            var numStringsFromQueryStringsSeenSoFar = 0;

            var result = new Subarray(-1, -1);
            var idx = 0;
            var loc = new List<string>();
            while (iter.MoveNext())
            {
                var s = iter.Current;

                if (dict.ContainsKey(s))
                {
                    // s is in queryStrings.
                    var it = dict[s];
                    if (it == int.MinValue)
                    {
                        // First time seeing this string from queryStrings.
                        numStringsFromQueryStringsSeenSoFar++;
                    }

                    loc.Remove(s);
                    dict[s] = idx;
                    loc.Add(s);
                }

                if (numStringsFromQueryStringsSeenSoFar == queryStrings.Count)
                {
                    // We have seen all strings in queryStrings, let’s get to work.
                    if ((result.Start == -1 && result.End == -1)
                        || idx - dict[loc.First()] < result.End - result.Start)
                    {
                        result.Start = dict[loc.First()];
                        result.End = idx;
                    }
                }
                ++idx;
            }
            return result;
        }
    }
}