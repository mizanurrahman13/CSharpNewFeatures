namespace LC240_Searcha2DMatrixII;

public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int row = 0;
        int col = matrix[0].Length - 1;

        while (row < matrix.Length && col >= 0)
        {
            if (matrix[row][col] == target)
                return true;
            else if (matrix[row][col] > target)
                col--;
            else
                row++;
        }

        return false;
    }

    //public bool SearchMatrix(int[][] matrix, int target)
    //{
    //    for (int row =  0; row < matrix.Length; row++)
    //    {
    //        for (int col = 0;  col < matrix[row].Length; col++)
    //        {
    //            if (matrix[row][col] == target)
    //                return true;
    //        }
    //    }

    //    return false;
    //}
}
