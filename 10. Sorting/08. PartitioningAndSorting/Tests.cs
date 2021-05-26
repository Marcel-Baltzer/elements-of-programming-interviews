using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._10._Sorting._08._PartitioningAndSorting
{
    public class Tests
    {
        [Fact]
        public void GroupByAge()
        {
            var list = new List<Solution.Person>()
            {
                new (14, "Greg"),
                new (12, "John"),
                new (11, "Andy"),
                new (13, "Jim"),
                new (12, "Phil"),
                new (13, "Bob"),
                new (13, "Chip"),
                new (14, "Tim"),
            };
            
            Solution.GroupByAge(list);

            var expectedList = new List<Solution.Person>()
            {
                new (14, "Greg"),
                new (14, "Tim"),
                new (12, "John"),
                new (12, "Phil"),
                new (11, "Andy"),
                new (13, "Jim"),
                new (13, "Bob"),
                new (13, "Chip"),

            };

            list.Should().BeEquivalentTo(expectedList, options => options.WithStrictOrdering());
        }
    }
}