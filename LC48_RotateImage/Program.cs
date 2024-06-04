using LC48_RotateImage;

Solution solution = new Solution();

int N = 4;

int[][] matrix = new int[3][]
{
    new int[] {1, 2, 3 },
    new int[] {4, 5, 6 },
    new int[] {7, 8, 9 }
};

solution.Rotate(matrix);

for (int i = 0; i < matrix.Length; i++)
{
    for (int j = 0; j < matrix[i].Length; j++)
    {
        Console.Write(matrix[i][j] + " ");
    }
    Console.WriteLine();
}

