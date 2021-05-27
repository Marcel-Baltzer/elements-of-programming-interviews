using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._02._Arrays._07._BuyAndSellStockTwice
{
    public class Tests
    {
        [Fact]
        public void BuyAndSellStockTwice()
        {
            var prices = new List<double>() {12,11,13,9,12,8,14,13,15};

            var result = Solution.BuyAndSellStockTwice(prices);

            result.Should().Be(10);
        }
    }
}