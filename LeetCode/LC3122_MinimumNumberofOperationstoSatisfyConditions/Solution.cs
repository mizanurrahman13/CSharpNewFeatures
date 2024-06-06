namespace LC3122_MinimumNumberofOperationstoSatisfyConditions;

public class Solution
{
    int[][] counts;
    int[][] dp;
    public int MinimumOperations(int[][] grid)
    {
        counts = new int[grid[0].Length][];
        dp = new int[grid[0].Length][];

        for (int col = 0; col < counts.Length; col++)
        {
            counts[col] = new int[10];
            dp[col] = new int[11];
            Array.Fill(dp[col], -1);
        }

        for (int col = 0; col < grid[0].Length; col++)
        {
            for (int row = 0; row < grid.Length; row++)
            {
                counts[col][grid[row][col]]++;
            }
        }

        return Solve(grid, 0, -1);
    }

    private int Solve(int[][] grid, int col, int previous)
    {
        if (grid[0].Length == col)
            return 0;
        if (dp[col][previous + 1] != -1)
            return dp[col][previous + 1];

        int result = int.MaxValue;
        for (int target = 0; target <=9; target++)
        {
            if (target == previous)
                continue;

            result = Math.Min(result, Solve(grid, col + 1, target) + grid.Length - counts[col][target]);
        }

        return dp[col][previous + 1] = result;
    }
}