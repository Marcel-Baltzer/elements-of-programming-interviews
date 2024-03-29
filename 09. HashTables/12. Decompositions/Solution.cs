using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._09._HashTables._12._Decompositions
{
    public class Solution
    {
        public static List<int> FindAllSubstrings(string s, List<string> words)
        {
            var wordToFreq = new Dictionary<string, int>();

            foreach (var word in words)
            {
                Increment(word, wordToFreq);
            }

            var unitSize = words[0].Length;
            var result = new List<int>();

            for (var i = 0; i + unitSize * words.Count <= s.Length; ++i)
            {
                if (MatchAllWordsInDict(s, wordToFreq, i, words.Count, unitSize))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        private static bool MatchAllWordsInDict(string s, IReadOnlyDictionary<string, int> wordToFreq, 
                                                int start, int numWords, int unitSize)
        {
            var currStringToFreq = new Dictionary<string, int>();

            for (var i = 0; i < numWords; ++i)
            {
                var currWord = s.Substring(start + i * unitSize, unitSize);

                if (!wordToFreq.ContainsKey(currWord))
                {
                    return false;
                }
                Increment(currWord, currStringToFreq);
                var freq = wordToFreq[currWord];

                if (currStringToFreq[currWord] > freq)
                {
                    // currWord occurs too many times for a match to be possible.
                    return false;
                }
            }
            return true;
        }

        private static void Increment(string word, IDictionary<string, int> dict)
        {
            var count = 0;
            if (dict.ContainsKey(word))
            {
                count = dict[word];
            }

            count++;
            dict[word] = count;
        }
    }
}