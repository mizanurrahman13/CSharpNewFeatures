namespace LC994_RottingOranges;

public class Solution
{
    public int OrangesRotting(int[][] grid)
    {
        int rows = grid.Length, cols = grid[0].Length;
        Queue<(int, int)> queue = new Queue<(int, int)>();
        int freshCount = 0, minutes = 0;

        // Step 1: Add rotten oranges to queue & count fresh ones
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (grid[r][c] == 2) queue.Enqueue((r, c));
                else if (grid[r][c] == 1) freshCount++;
            }
        }

        // Step 2: BFS to spread rot
        int[][] directions = { new[] { 0, 1 }, new[] { 0, -1 }, new[] { 1, 0 }, new[] { -1, 0 } };
        while (queue.Count > 0 && freshCount > 0)
        {
            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                var (r, c) = queue.Dequeue();
                foreach (var dir in directions)
                {
                    int nr = r + dir[0], nc = c + dir[1];
                    if (nr >= 0 && nc >= 0 && nr < rows && nc < cols && grid[nr][nc] == 1)
                    {
                        grid[nr][nc] = 2;
                        queue.Enqueue((nr, nc));
                        freshCount--;
                    }
                }
            }
            minutes++;
        }

        return freshCount == 0 ? minutes : -1;
    }
}
