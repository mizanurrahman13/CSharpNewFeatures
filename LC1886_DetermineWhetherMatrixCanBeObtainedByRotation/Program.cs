using LC1886_DetermineWhetherMatrixCanBeObtainedByRotation;

Solution solution = new Solution();

int[][] mat = new int[3][]
{
    new int[] {0, 0, 0 },
    new int[] {0, 1, 0 },
    new int[] {1, 1, 1 }
};

int[][] target = new int[3][]
{
    new int[] {1, 1, 1 },
    new int[] {0, 1, 0 },
    new int[] {0, 0, 0 }
};
Console.WriteLine(solution.FindRotation(mat, target));
