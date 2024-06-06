using LC3142_CheckifGridSatisfiesConditions;

Solution solution = new Solution();

int[][] grid = new int[][]
{
    new int[] {1, 0, 2},
    new int[] {1, 0, 2}
};

Console.WriteLine(solution.SatisfiesConditions(grid));
