using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._10._Sorting._00._BootCamp
{
    public class Tests
    {
        [Fact]
        public void SortByName()
        {
            var list = new List<Solution.Student>
            {
                new ("A", 2),
                new ("C", 4),
                new ("E", 6),
                new ("B", 3),
                new ("D", 1)
            };

            Solution.SortByName(list);
            
            var expectedResult = new List<Solution.Student>
            {
                new ("A", 2),
                new ("B", 3),
                new ("C", 4),
                new ("D", 1),
                new ("E", 6)
            };

            list.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }
        
        [Fact]
        public void SortByGradePointAverage()
        {
            var list = new List<Solution.Student>
            {
                new ("A", 2),
                new ("C", 4),
                new ("E", 6),
                new ("B", 3),
                new ("D", 1)
            };
            
            Solution.SortByGradePointAverage(list);
            
            var expectedResult = new List<Solution.Student>
            {
                new ("D", 1),
                new ("A", 2),
                new ("B", 3),
                new ("C", 4),
                new ("E", 6)
            };

            list.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }
    }
}