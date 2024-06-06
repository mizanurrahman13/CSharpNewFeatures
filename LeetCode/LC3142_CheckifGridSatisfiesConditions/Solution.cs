namespace LC3142_CheckifGridSatisfiesConditions;

public class Solution
{
    public bool SatisfiesConditions(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;

        for (int row = 0; row < m; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (row != m - 1 && grid[row][col]  != grid[row + 1][col])
                    return false;
                if (col != n - 1 && grid[row][col] == grid[row][col + 1])
                    return false;
            }
        }

        return true;
    }
}
