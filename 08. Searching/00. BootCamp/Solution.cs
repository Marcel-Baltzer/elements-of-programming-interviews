using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._08._Searching._00._BootCamp
{
    public class Solution
    {
        public class Student
        {
            public readonly string Name;
            public readonly double GradePointAverage;

            public Student(string name, double gradePointAverage)
            {
                Name = name;
                GradePointAverage = gradePointAverage;
            }
        }

        public class CompGPA : Comparer<Student>
        {
            public override int Compare(Student a, Student b)
            {
                if (a.GradePointAverage != b.GradePointAverage)
                {
                    return a.GradePointAverage.CompareTo(b.GradePointAverage);
                }
                return a.Name.CompareTo(b.Name);
            }
        };

        public static bool SearchStudent(List<Student> students, Student target, Comparer<Student> compGPA)
        {
            return students.BinarySearch(target, compGPA) >= 0;
        }
    }
}