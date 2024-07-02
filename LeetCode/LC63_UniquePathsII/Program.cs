using LC63_UniquePathsII;

Solution solution = new Solution();

int[][] obstacleGrid = new int[][]
{
    new int[] { 0, 0, 0},
    new int[] { 0, 1, 0},
    new int[] { 0, 0, 0},
};

Console.WriteLine(solution.UniquePathsWithObstacles(obstacleGrid));
