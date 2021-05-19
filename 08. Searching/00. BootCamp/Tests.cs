using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Searching.BootCamp
{
    public class Tests
    {
        [Fact]
        public void SearchStudent()
        {
            var list = new List<Solution.Student>()
            {
                new Solution.Student("student1", 1.2),
                new Solution.Student("student2", 5.2),
                new Solution.Student("student3", 5.2),
                new Solution.Student("student4", 3.2),
                new Solution.Student("student5", 2.8)
            };

            var comparer = new Solution.CompGPA();

            var target = new Solution.Student("student3", 5.2);

            var result = Solution.SearchStudent(list, target, comparer);

            result.Should().BeTrue();
        }
    }
}