using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._12._Recursion._07._PalindromicDecompositions
{
    public class Tests
    {
        [Fact]
        public void PalindromePartitioning()
        {
            var result = Solution.PalindromePartitioning("0204451881");

            var expectedResult = new List<List<string>>
            {
                new() {"0", "2", "0", "4", "4", "5", "1", "8", "8", "1"},
                new() {"0", "2", "0", "4", "4", "5", "1", "88", "1"},
                new() {"0", "2", "0", "4", "4", "5", "1881"},
                new() {"0", "2", "0", "44", "5", "1", "8", "8", "1"},
                new() {"0", "2", "0", "44", "5", "1", "88", "1"},
                new() {"0", "2", "0", "44", "5", "1881"},
                new() {"020", "4", "4", "5", "1", "8", "8", "1"},
                new() {"020", "4", "4", "5", "1", "88", "1"},
                new() {"020", "4", "4", "5", "1881"},
                new() {"020", "44", "5", "1", "8", "8", "1"},
                new() {"020", "44", "5", "1", "88", "1"},
                new() {"020", "44", "5", "1881"}
            };

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}