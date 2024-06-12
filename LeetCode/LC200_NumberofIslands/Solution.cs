namespace LC200_NumberofIslands;

public class Solution
{
    public int NumIslands(char[][] grid)
    {
        int count = 0;

        for (int i =  0; i < grid.Length; i++)
        {
            for (int j = 0;  j < grid[0].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    Iland(grid, i, j);
                    count++;
                }

            }
        }

        return count;
    }

    private void Iland(char[][] grid, int i, int j)
    {
        if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length) 
            return;

        if (grid[i][j] == '0')
            return;

        grid[i][j] = '0';

        Iland(grid, i + 1, j);
        Iland(grid, i - 1, j);
        Iland(grid, i, j + 1);
        Iland(grid, i, j - 1);
    }
}
