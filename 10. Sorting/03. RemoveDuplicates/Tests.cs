using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._10._Sorting._03._RemoveDuplicates
{
    public class Tests
    {
        [Fact]
        public void EliminateDuplicate()
        {
            var list = new List<Solution.Name>()
            {
                new Solution.Name("Ian", "Botham"),
                new Solution.Name("David", "Gower"),
                new Solution.Name("Ian", "Bell"),
                new Solution.Name("Ian", "Chappell"),
            };
            
            Solution.EliminateDuplicate(list);

            var expectedResult = new List<Solution.Name>()
            {
                new Solution.Name("David", "Gower"),
                new Solution.Name("Ian", "Bell"),
            };
            
            list.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }
    }
}