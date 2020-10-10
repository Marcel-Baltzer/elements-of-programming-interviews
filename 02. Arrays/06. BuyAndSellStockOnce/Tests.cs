using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Arrays.BuyAndSellStockOnce
{
    public class Tests
    {
        [Fact]
        public void ComputeMaxProfit()
        {
            var prices = new List<double>() {310,315,275,295,260,270,290,230,255,250};

            var result = Solution.ComputeMaxProfit(prices);

            result.Should().Be(30);
        }
    }
}