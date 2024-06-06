public class Solution
{
    //public int ClimbStairs(int n, int[] dp)
    //{
    //    //int[] dp=new int[n];

    //    if (n <= 1)
    //        return dp[n] = 1;



    //    if (dp[n] != -1)
    //    {
    //        return dp[n];
    //    }
    //    dp[n] = ClimbStairs(n - 1, dp) + ClimbStairs(n - 2, dp);
    //    return dp[n];
    //}

    //public int ClimbStairs(int n)
    //{
    //    int[] dp = new int[n + 1];
    //    dp[0] = 1;
    //    dp[1] = 1;

    //    for (int i = 2; i <= n; i++)
    //        dp[i] = dp[i - 1] + dp[i - 2];

    //    return dp[n];
    //}

    public int ClimbStairs(int n)
    {
        int[] dp = new int[n + 1];
        dp[0] = 1;
        dp[1] = 1;

        for (int i = 2; i <= n; i++)
            dp[i] = dp[i - 1] + dp[i - 2];

        return dp[n];
    }
}