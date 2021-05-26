using System.Collections.Generic;
using System.Linq;

namespace Elements_of_Programming_Interviews._10._Sorting._08._PartitioningAndSorting
{
    public class Solution
    {
        public class Person
        {
            public readonly int Age;
            public readonly string Name;

            public Person(int age, string name)
            {
                Age = age;
                Name = name;
            }
        }

        public static void GroupByAge(List<Person> people)
        {
            var ageToCount = new Dictionary<int, int>();

            foreach (var person in people)
            {
                if (ageToCount.ContainsKey(person.Age))
                {
                    ageToCount[person.Age] = ageToCount[person.Age] + 1;
                }
                else
                {
                    ageToCount[person.Age] = 1;
                }
            }

            var ageToOffset = new Dictionary<int, int>();
            var offSet = 0;

            foreach (var (key, value) in ageToCount)
            {
                ageToOffset[key] = offSet;
                offSet += value;
            }

            while (ageToOffset.Any())
            {
                var from = ageToOffset.First();

                var toAge = people[from.Value].Age;
                var toValue = ageToOffset[toAge];
                Swap(people, from.Value, toValue);
                // Use ageToCount to see when we are finished with a particular age.
                var count = ageToCount[toAge] - 1;
                ageToCount[toAge] = count;
                if (count > 0)
                {
                    ageToOffset[toAge] = toValue + 1;
                }
                else
                {
                    ageToOffset.Remove(toAge);
                }
            }
        }

        private static void Swap<T>(IList<T> list, int i, int j)
        {
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}