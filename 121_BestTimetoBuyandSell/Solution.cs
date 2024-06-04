namespace _121_BestTimetoBuyandSell;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        //Array.Sort(prices);
        //int minValue = prices.Min();       

        //for (int i = 0; i < prices.Length; i++)
        //{
        //    if (prices[i] == minValue)
        //        minIndex = i;
        //}

        //for (int i = minIndex; i < prices.Length-1; i++)
        //{
        //    if (prices[i+1] - prices[minIndex] > maxProfit)
        //        maxProfit = prices[i+1] - prices[minIndex];
        //}

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
