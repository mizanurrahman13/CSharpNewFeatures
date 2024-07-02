namespace LC63_UniquePathsII;

public class Solution
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        int rows = obstacleGrid.Length;
        int cols = obstacleGrid[0].Length;
        int[][] dp = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            dp[i] = new int[cols];
        }

        return FindPath(rows - 1, cols - 1, obstacleGrid, dp);
    }

    int FindPath(int rows, int cols, int[][] obstacleGrid, int[][] dp)
    {
        if (dp[rows][cols] != 0)
            return dp[rows][cols];
        if (obstacleGrid[rows][cols] == 1)
            return dp[rows][cols] = 0;
        if (rows == 0 && cols == 0)
            return dp[0][0] = 1;

        int left = 0;
        int down = 0;

        if (rows > 0)
            left = FindPath(rows - 1, cols, obstacleGrid, dp);
        if (cols > 0)
            down = FindPath(rows, cols - 1, obstacleGrid, dp);

        return dp[rows][cols] = left + down;
    }
}
