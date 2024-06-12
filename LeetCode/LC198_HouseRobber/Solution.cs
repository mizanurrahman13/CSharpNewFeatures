namespace LC198_HouseRobber;

public class Solution
{
    public int Rob(int[] nums)
    {

        //int rob1 = 0, rob2 = 0;

        //foreach (int x in nums)
        //{
        //    int temp = Math.Max(x + rob1, rob2);
        //    rob1 = rob2;
        //    rob2 = temp;
        //}

        //return rob2;

        int n = nums.Length;
        int[] dp = new int[n];
        Array.Fill(dp, -1);

        return ChooseHouse();

        int ChooseHouse(int i = 0)
        {
            if (i >= n) return 0;
            if (dp[i] != -1) return dp[i];   // if sub-problem is already solved return from cache

            // return max of either
            // a. skipping current house and continuing with next one
            // b. or robbing current and than continuing with idx+2
            return dp[i] = Math.Max(ChooseHouse(i + 1), nums[i] + ChooseHouse(i + 2));
        }
    }

    //public int Rob(int[] nums)
    //{
    //    int len = nums.Length;
    //    if (len == 0) return 0;
    //    return MaxNonAdjacentSum(nums, 0, len, new Dictionary<int, int>(100));

    //}
    //// DP Memoization approach (Top-Down)
    //public int MaxNonAdjacentSum(int[] nums, int i, int len, Dictionary<int, int> memo)
    //{
    //    if (i >= len) return 0;
    //    if (memo.ContainsKey(i)) return memo[i];
    //    memo.Add(i, Math.Max(nums[i] + MaxNonAdjacentSum(nums, i + 2, len, memo), MaxNonAdjacentSum(nums, i + 1, len, memo)));
    //    return memo[i];
    //}
}


