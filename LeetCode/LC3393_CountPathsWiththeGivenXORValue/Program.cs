using LC3393_CountPathsWiththeGivenXORValue;

Solution solution = new Solution();

//int[][] grid = [[2, 1, 5], [7, 10, 0], [12, 6, 4]];
//int k = 11;
int[][] grid = [[1, 3, 3, 3], [0, 3, 3, 2], [3, 0, 1, 1]];
int k = 2;

Console.WriteLine(solution.CountPathsWithXorValue(grid, k));
