using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._12._Recursion._01._TowersOfHanoiProblem
{
    public class Tests
    {
        [Fact]
        public void ComputeTowerHanoi()
        {
            var result = Solution.ComputeTowerHanoi(5);

            var expectedResult = new List<string>
            {
                "Move 1 from peg 0 to peg 1", 
                "Move 2 from peg 0 to peg 2", 
                "Move 1 from peg 1 to peg 2", 
                "Move 3 from peg 0 to peg 1", 
                "Move 1 from peg 2 to peg 0", 
                "Move 2 from peg 2 to peg 1", 
                "Move 1 from peg 0 to peg 1", 
                "Move 4 from peg 0 to peg 2", 
                "Move 1 from peg 1 to peg 2", 
                "Move 2 from peg 1 to peg 0", 
                "Move 1 from peg 2 to peg 0", 
                "Move 3 from peg 1 to peg 2", 
                "Move 1 from peg 0 to peg 1", 
                "Move 2 from peg 0 to peg 2", 
                "Move 1 from peg 1 to peg 2", 
                "Move 5 from peg 0 to peg 1", 
                "Move 1 from peg 2 to peg 0", 
                "Move 2 from peg 2 to peg 1", 
                "Move 1 from peg 0 to peg 1", 
                "Move 3 from peg 2 to peg 0", 
                "Move 1 from peg 1 to peg 2", 
                "Move 2 from peg 1 to peg 0", 
                "Move 1 from peg 2 to peg 0", 
                "Move 4 from peg 2 to peg 1", 
                "Move 1 from peg 0 to peg 1", 
                "Move 2 from peg 0 to peg 2", 
                "Move 1 from peg 1 to peg 2", 
                "Move 3 from peg 0 to peg 1", 
                "Move 1 from peg 2 to peg 0", 
                "Move 2 from peg 2 to peg 1", 
                "Move 1 from peg 0 to peg 1"
            };

            result.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }
    }
}