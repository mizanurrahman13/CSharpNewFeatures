namespace LC3393_CountPathsWiththeGivenXORValue;

public class Solution
{
    private int[][] grid;
    private int m, n, target;
    private long[][][] dp;

    public int CountPathsWithXorValue(int[][] grid, int k)
    {
        this.grid = grid;
        m = grid.Length;
        n = grid[0].Length;
        target = k;
        dp = new long[m][][];
        for (int i = 0; i < m; i++)
        {
            dp[i] = new long[n][];
            for (int j = 0; j < n; j++)
            {
                dp[i][j] = new long[16];
            }
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Array.Fill(dp[i][j], -1);
            }
        }

        return (int)SinglePath(0, 0, grid[0][0]);
    }

    long SinglePath(int i, int j, int value)
    {
        long ways = 0;
        if (i == m - 1 && j == n - 1)
            return value == target ? 1 : 0;
        if (dp[i][j][value] != -1)
            return dp[i][j][value];

        if (i + 1 < m)
            ways += SinglePath(i + 1, j, value ^ grid[i + 1][j]);
        if (j + 1 < n)
            ways += SinglePath(i, j + 1, value ^ grid[i][j + 1]);
        ways %= 1000000007;
        dp[i][j][value] = ways;

        return ways;
    }    
}