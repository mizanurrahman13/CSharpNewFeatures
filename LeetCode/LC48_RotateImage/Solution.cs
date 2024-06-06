namespace LC48_RotateImage;

public class Solution
{
    public void Rotate(int[][] matrix)
    {
        Transpose(matrix);
        ReverseRows(matrix);
    }

    private void Transpose(int[][] matrix)
    {
        int length = matrix.Length;

        for (int i = 0; i < length; i++)
        {
            for (int j = i + 1; j < length; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }
    }

    private void ReverseRows(int[][] matrix)
    {
        int length = matrix.Length;

        for (int i = 0; i < length; i++)
        {
            Array.Reverse(matrix[i]);
        }
    }
}
