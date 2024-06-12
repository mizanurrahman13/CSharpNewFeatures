namespace LC3180_MaximumTotalRewardUsingOperationsI;

public class Solution
{
    int[][] dp;
    //public int MaxTotalReward(int[] rewardValues)
    //{        
    //    Array.Sort(rewardValues);
    //    int length = rewardValues.Length;
    //    dp = new int[length][];
    //    for (int i = 0; i < length; i++)
    //    {
    //        dp[i] = new int[4000];
    //        Array.Fill(dp[i], -1);
    //    }

    //    return TotalReward(0, 0, rewardValues);
    //}

    //private int TotalReward(int i, int target, int[] reward)
    //{
    //    if (i == reward.Length)
    //        return target;

    //    if (dp[i][target] != -1)
    //        return dp[i][target];

    //    int leave = TotalReward(i+1, target, reward);
    //    int take = 0;

    //    if (reward[i] > target)
    //        take = TotalReward(i + 1, target + reward[i], reward);

    //    return dp[i][target] = Math.Max(leave, take);
    //}

    public int MaxTotalReward(int[] rewardValues)
    {
        int length = rewardValues.Length;
        dp = new int[length][];
        Array.Sort(rewardValues);        

        for (int i = 0; i < length; i++)
        {
            dp[i] = new int[4000];
            Array.Fill(dp[i], -1);
        }

        return CalculateTotalReward(0, 0, rewardValues);
    }

    private int CalculateTotalReward(int i, int target, int[] rewardValues)
    {
        if (i == rewardValues.Length)
            return target;

        if (dp[i][target] != -1)
            return dp[i][target];

        int leave = CalculateTotalReward(i + 1, target, rewardValues);
        int take = 0;

        if (rewardValues[i] > target)
            take = CalculateTotalReward(i + 1, target + rewardValues[i], rewardValues);

        return dp[i][target] = Math.Max(leave, take);
    }
}
