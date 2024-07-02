namespace LC62_UniquePaths;

public class Solution
{
    public int UniquePaths(int m, int n)
    {
        int[][] memoization = new int[m + 1][];

        for (int i = 0; i <= m; i++)
        {
            memoization[i] = new int[n+1];
            Array.Fill(memoization[i], 1);
        }

        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
                memoization[i][j] = memoization[i - 1][j] + memoization[i][j - 1];
        }

        return memoization[m - 1][n - 1];
    }
}
