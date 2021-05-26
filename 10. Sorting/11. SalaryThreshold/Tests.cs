using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._10._Sorting._11._SalaryThreshold
{
    public class Tests
    {
        [Fact]
        public void FindSalaryCap()
        {
            var list = new List<double>() {90, 30, 100, 40, 20};

            var result = Solution.FindSalaryCap(210, list);

            result.Should().Be(60);
        }
        
        [Fact]
        public void FindSalaryCapWithNoSolution()
        {
            var list = new List<double>() {90, 30, 0, 40, 20};

            var result = Solution.FindSalaryCap(210, list);

            result.Should().Be(-1);
        }
    }
}