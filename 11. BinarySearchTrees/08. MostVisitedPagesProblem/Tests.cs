using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._08._MostVisitedPagesProblem
{
    public class Tests
    {
        [Fact]
        public void MostVisitedPage()
        {
            var client = new Solution.MostVisitedPage();
            
            client.ReadLines(new List<string>() {"g","a","t","t","a","a"});

            var result = client.GetKMostVisitedPages(3);

            result.Should().BeEquivalentTo(
                new List<Solution.PageVisitCount>
                {
                    new("a", 3),
                    new("t", 2),
                    new("g", 1)
                }, options => options.WithStrictOrdering());
            
            client.ReadLines(new List<string>() {"a","g","t","c","t","a","t"});
            
            result = client.GetKMostVisitedPages(4);
            
            result.Should().BeEquivalentTo(
                new List<Solution.PageVisitCount>
                {
                    new("a", 5),
                    new("t", 5),
                    new("g", 2),
                    new("c", 1)
                }, options => options.WithStrictOrdering());
        }
    }
}