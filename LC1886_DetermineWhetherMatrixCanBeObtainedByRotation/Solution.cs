namespace LC1886_DetermineWhetherMatrixCanBeObtainedByRotation;

public class Solution
{
    public bool FindRotation(int[][] mat, int[][] target)
    {
        int count = 0;

        while (count < 4)
        {
            Transpose(mat);
            ReverseRows(mat);

            if (Compare(mat, target))
                return true;

            count++;
        }

        return false;
    }

    private void Transpose(int[][] mat)
    {
        int length = mat.Length;

        for (int i = 0; i < length; i++)
        {
            for (int j = i + 1; j < length; j++)
            {
                int temp = mat[i][j];
                mat[i][j] = mat[j][i];
                mat[j][i] = temp;
            }
        }
    }

    private void ReverseRows(int[][] mat)
    {
        int length = mat.Length;

        for (int i = 0; i < length; i++)
        {
            Array.Reverse(mat[i]);
        }
    }

    private bool Compare(int[][] mat, int[][] target)
    {
        int rows = mat.Length;
        int cols = mat[0].Length;

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (mat[r][c] != target[r][c]) 
                    return false;
            }
        }

        return true;
    }
}
