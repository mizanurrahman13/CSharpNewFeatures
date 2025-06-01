using LC994_RottingOranges;

Solution solution = new Solution();

int[][] grid1 = {
            new int[] {2, 1, 1},
            new int[] {1, 1, 0},
            new int[] {0, 1, 1}
        };
Console.WriteLine(solution.OrangesRotting(grid1)); // Output: 4

int[][] grid2 = {
            new int[] {2, 1, 1},
            new int[] {0, 1, 1},
            new int[] {1, 0, 1}
        };
Console.WriteLine(solution.OrangesRotting(grid2)); // Output: -1

int[][] grid3 = {
            new int[] {0, 2}
        };
Console.WriteLine(solution.OrangesRotting(grid3)); // Output: 0
