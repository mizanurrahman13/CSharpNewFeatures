namespace LC3127_MakeaSquarewiththeSameColor;

public class Solution
{
    public bool CanMakeSquare(char[][] grid)
    {
        for (int row =  0; row < 2; row++)
        {
            for (int col = 0; col < 2; col++)
            {
                int count = 0;
                if (grid[row][col] == 'B')
                    count++;
                if (grid[row + 1][col] == 'B')
                    count++;
                if (grid[row][col + 1] == 'B')
                    count++;
                if (grid[row + 1][col + 1] == 'B')
                    count++;

                if (count != 2)
                    return true;
            }
        }

        return false;
    }
}