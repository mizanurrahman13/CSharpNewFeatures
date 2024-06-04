using LC3122_MinimumNumberofOperationstoSatisfyConditions;

Solution solution = new Solution();

//int[][] grid = new int[][]
//{
//    new int[] {1, 0, 2},
//    new int[] {1, 0, 2}
//};
int[][] grid = new int[][]
{
    new int[] {1, 1, 1},
    new int[] {0, 0, 0}
};

Console.WriteLine(solution.MinimumOperations(grid));
