namespace LC_130_SurroundedRegions;

public class Solution
{
    public int rows=0;
    public int cols=0;
    public void Solve(char[][] board)
    {
        if (board == null || board.Length == 0) return;

        rows = board.Length;
        cols = board[0].Length;

        // Step 1: Mark boundary-connected 'O's as temporary ('T')
        for (int i = 0; i < rows; i++)
        {
            Capture(board, i, 0);         // Left boundary
            Capture(board, i, cols - 1);  // Right boundary
        }
        for (int j = 0; j < cols; j++)
        {
            Capture(board, 0, j);         // Top boundary
            Capture(board, rows - 1, j);  // Bottom boundary
        }

        // Step 2: Convert surrounded 'O's to 'X' and restore 'T' to 'O'
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (board[i][j] == 'O')
                    board[i][j] = 'X'; // Capture region
                else if (board[i][j] == 'T')
                    board[i][j] = 'O'; // Restore non-surrounded region
            }
        }
    }

    private void Capture(char[][] board, int i, int j)
    {
        // Base Case: Check out-of-bounds or non-'O' cells
        if (i < 0 || j < 0 || i >= rows || j >= cols || board[i][j] != 'O')
            return;

        board[i][j] = 'T'; // Temporarily mark

        // Explore neighbors (Capture)
        Capture(board, i + 1, j);
        Capture(board, i - 1, j);
        Capture(board, i, j + 1);
        Capture(board, i, j - 1);
    }

    public void PrintBoard(char[][] board)
    {
        foreach (var row in board)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
}
