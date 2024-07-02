namespace LC122_BestTimetoBuyandSellStockII;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        int length = prices.Length;
        for (int i = 1; i < length; i++)
        {
            if (prices[i] > prices[i-1])
            {
                maxProfit += prices[i] - prices[i - 1];
            }
        }

        return maxProfit;
    }
}
