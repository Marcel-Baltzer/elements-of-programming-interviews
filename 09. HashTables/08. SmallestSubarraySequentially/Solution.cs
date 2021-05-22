using System.Collections.Generic;

namespace Elements_of_Programming_Interviews.HashTables.SmallestSubarraySequentially
{
    public class Solution
    {
        // Represent subarray by starting and ending indices, inclusive.
        public class Subarray {
            
            public int Start;
            public int End;
            
            public Subarray(int start, int end) {
                Start = start ;
                End = end;
            }
        }

        public static Subarray FindSmallestSequentiallyCoveringSubset(List<string> paragraph, List<string> keywords)
        {
            // Maps each keyword to its index in the keywords array.
            var keywordToIdx = new Dictionary<string, int>();
            
            // Since keywords are uniquely identified by their indices in keywords
            // array, we can use those indices as keys to lookup in a vector.
            var latestOccurrence = new List<int>();
            
            // For each keyword (identified by its index in keywords array), stores the
            // length of the shortest subarray ending at the most recent occurrence of
            // that keyword that sequentially cover all keywords up to that keyword.
            var shortestSubarrayLength = new List<int>();
            
            // Initializes latestOccurrence , shortestSubarrayLength , and keywordToIdx.
            for (var i = 0; i < keywords.Count; ++i)
            {
                latestOccurrence.Add(-1);
                shortestSubarrayLength.Add(int.MaxValue);
                keywordToIdx[keywords[i]] = i;
            }

            var shortestDistance = int.MaxValue;
            var result = new Subarray(-1, -1);

            for (var i = 0; i < paragraph.Count; ++i)
            {
                if (keywordToIdx.ContainsKey(paragraph[i]))
                {
                    var keywordIdx = keywordToIdx[paragraph[i]];
                    if (keywordIdx == 0) // First keyword.
                    {
                        shortestSubarrayLength[0] = 1;
                    }
                    else if(shortestSubarrayLength[keywordIdx - 1] != int.MaxValue)
                    {
                        var distanceToPreviousKeyword = i - latestOccurrence[keywordIdx - 1];
                        shortestSubarrayLength[keywordIdx] =
                            distanceToPreviousKeyword + shortestSubarrayLength[keywordIdx - 1];
                    }

                    latestOccurrence[keywordIdx] = i;
                    
                    // Last keyword, look for improved subarray.
                    if (keywordIdx == keywords.Count - 1 &&
                        shortestSubarrayLength[shortestSubarrayLength.Count - 1] < shortestDistance)
                    {
                        shortestDistance = shortestSubarrayLength[shortestSubarrayLength.Count - 1];
                        result.Start = i - shortestSubarrayLength[shortestSubarrayLength.Count - 1] + 1;

                        result.End = i;
                    }
                }
            }
            
            return result;
        }
    }
}