using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._02._Arrays._07._BuyAndSellStockTwice
{
    public class Solution
    {
        public static double BuyAndSellStockTwice(List<double> prices)
        {
            var maxTotalProfit = 0.0;
            var firstBuySellProfits = new List<double>();
            var minPriceSoFar = double.MaxValue;

            // Forward phase. 
            // For each day, we record maximum profit if we sell on that day.
            for (var i = 0; i < prices.Count; i++)
            {
                minPriceSoFar = Math.Min(minPriceSoFar, prices[i]);
                maxTotalProfit = Math.Max(maxTotalProfit, prices[i] - minPriceSoFar);
                firstBuySellProfits.Add(maxTotalProfit);
            }

            // Backward phase. 
            // For each day, find the maximum profit if we make the second buy on that day.
            var maxPriceSoFar = double.MinValue;

            for(var i = prices.Count -1; i > 0; i--)
            {
                maxPriceSoFar = Math.Max(maxPriceSoFar, prices[i]);
                maxTotalProfit = Math.Max(maxTotalProfit, maxPriceSoFar - prices[i] + firstBuySellProfits[i-1]);
            }

            return maxTotalProfit;
        }
    }
}