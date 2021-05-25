using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._10._Sorting._03._RemoveDuplicates
{
    public class Solution
    {
        public class Name : IComparable
        {
            public readonly string FirstName;
            public readonly string LastName;

            public Name(string firstName, string lastName)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
            }

            public int CompareTo(object obj)
            {
                var name = obj as Name;

                var cmpFirst = FirstName.CompareTo(name.FirstName);
                if (cmpFirst != 0)
                {
                    return cmpFirst;
                }

                return LastName.CompareTo(name.LastName);
            }
        }

        public static void EliminateDuplicate(List<Name> A)
        {
            A.Sort(); // Makes identical elements become neighbors.
            var result = 0;

            for (var first = 1; first < A.Count; first++)
            {
                if (!A[first].FirstName.Equals(A[result].FirstName))
                {
                    A[++result] = A[first];
                }
            }
            // Shrinks array size.
            A.RemoveRange(++result, A.Count - result);
        }
    }
}