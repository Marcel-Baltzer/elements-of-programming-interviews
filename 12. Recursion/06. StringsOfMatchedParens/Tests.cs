using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._12._Recursion._06._StringsOfMatchedParens
{
    public class Tests
    {
        [Fact]
        public void GenerateBalancedParentheses()
        {
            var result = Solution.GenerateBalancedParentheses(3);

            var expectedResult = new List<string>
            {
                "((()))", 
                "(()())", 
                "(())()", 
                "()(())", 
                "()()()"
            };

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}