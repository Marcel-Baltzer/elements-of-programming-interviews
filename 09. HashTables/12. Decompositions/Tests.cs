using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._09._HashTables._12._Decompositions
{
    public class Tests
    {
        [Fact]
        public void FindAllSubstrings()
        {
            var sentence = "amanaplanacanalcanaplana";
            var words = new List<string>() {"can", "apl", "ana"};

            var result = Solution.FindAllSubstrings(sentence, words);

            var expectedResult = new List<int>() {4, 15};

            result.Should().BeEquivalentTo(expectedResult);
        }
        
    }
}