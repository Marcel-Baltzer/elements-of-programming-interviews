using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.HashTables.NearestRepeatedEntries
{
    public class Tests
    {
        [Fact]
        public void FindNearestRepetition()
        {
            var list = new List<string>() 
                {"All", "work", "and", "no", "play", "makes", "for", "no", "work", "no", "fun", "and", "no", "results"};
            
            var result = Solution.FindNearestRepetition(list);

            result.Should().Be(2);
        }
    }
}