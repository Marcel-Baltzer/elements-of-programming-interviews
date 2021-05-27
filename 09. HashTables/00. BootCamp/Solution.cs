using System;
using System.Collections.Generic;
using System.Linq;

namespace Elements_of_Programming_Interviews._09._HashTables._00._BootCamp
{
    public class Solution
    {
        public static List<List<string>> FindAnagrams(List<string> dictionary)
        {
            var sortedStringToAnagrams = new Dictionary<string, List<string>>();

            foreach (var s in dictionary)
            {
                // Sorts the string, uses it as a key, and then appends
                // the original string as another value in the hash table.
                var sortedCharArray = s.ToCharArray();
                Array.Sort(sortedCharArray);
                var sortedStr = new string(sortedCharArray);

                if (!sortedStringToAnagrams.ContainsKey(sortedStr))
                {
                    sortedStringToAnagrams[sortedStr] = new List<string>();
                }

                sortedStringToAnagrams[sortedStr].Add(s);
            }

            var anagramGroups = new List<List<string>>();

            foreach (var p in sortedStringToAnagrams)
            {
                if (p.Value.Count >= 2)
                {
                    // Found anagrams.
                    anagramGroups.Add(p.Value);
                }
            }

            return anagramGroups;
        }

        public static List<ContactList> MergeContactLists(List<ContactList> contact)
        {
            return contact.ToHashSet().ToList();
        }

        public class ContactList
        {
            private readonly List<string> names;

            public ContactList(List<string> names)
            {
                this.names = names;
            }

            public override bool Equals(object obj)
            {
                if(obj == null || !(obj is ContactList))
                {
                    return false;
                }

                if (this == obj)
                {
                    return true;
                }

                return names.ToHashSet().SetEquals(((ContactList) obj).names.ToHashSet());
            }

            public override int GetHashCode()
            {
                return 0;
            }
        }
    }
}