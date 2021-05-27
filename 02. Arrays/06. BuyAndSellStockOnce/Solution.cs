using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._02._Arrays._06._BuyAndSellStockOnce
{
    public class Solution
    {
        public static double ComputeMaxProfit(List<double> prices)
        {
            var minPrice = double.MaxValue;
            var maxProfit = 0.0;

            foreach(var price in prices)
            {
                maxProfit = Math.Max(maxProfit, price - minPrice);
                minPrice = Math.Min(minPrice, price);
            }
            return maxProfit;            
        }
    }
}