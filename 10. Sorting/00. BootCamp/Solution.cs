using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._10._Sorting._00._BootCamp
{
    public class Solution
    {
        public class Student : IComparable
        {
            public readonly string Name;
            public readonly double GradePointAverage;

            public Student(string name, double gradePointAverage)
            {
                Name = name;
                GradePointAverage = gradePointAverage;
            }

            public int CompareTo(object obj)
            {
                if (obj is Student that)
                {
                    return string.Compare(Name, that.Name, StringComparison.Ordinal);
                }

                return -1;
            }
        }

        public static void SortByName(List<Student> students)
        {
            students.Sort();
        }

        public static void SortByGradePointAverage(List<Student> students)
        {
            students.Sort((a, b) => a.GradePointAverage.CompareTo(b.GradePointAverage));
        }
    }
}