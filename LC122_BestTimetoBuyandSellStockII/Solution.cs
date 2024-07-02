namespace LC122_BestTimetoBuyandSellStockII;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int minValue = int.MaxValue;
        int maxProfit = 0;

        for (int i = 0; i < prices.Length - 1; i++)
        {
            if (prices[i] < minValue)
                minValue = prices[i];
            if (prices[i + 1] - minValue > maxProfit)
                maxProfit = prices[i + 1] - minValue;
        }

        return maxProfit;
    }
}
