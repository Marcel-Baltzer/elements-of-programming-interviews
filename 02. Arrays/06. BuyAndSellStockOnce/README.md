## 6. Buy and sell a stock once

This problem is concerned with the problem of optimally buying and selling a stock once. As an example, consider the following sequence of stock prices: (310, 315, 275, 295, 260, 270, 290, 230, 255, 250). The maximum profit that can be made with one buy and one sell is 30 - buy at 260 and sell at 290. Note that 260 is not the lowest price, nor 290 the highest price.

Write a program that takes an array denoting the daily stock price, and returns the maximum profit that could be made by buying and then selling one share of that stock.

>Hint: Identifying the minimum and maximum is not enough since the minimum may appear after the maximum height. Focus on valid differences.