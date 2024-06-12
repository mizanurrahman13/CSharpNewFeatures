using LC200_NumberofIslands;

Solution solution = new Solution();

//char[][] grid = new char[][]
//{
//    new char[] { '1', '1', '1', '1', '0' },
//    new char[] { '1', '1', '0', '1', '0' },
//    new char[] { '1', '1', '0', '0', '0' },
//    new char[] { '0', '0', '0', '0', '0' }
//};
char[][] grid = new char[][]
{
    new char[] { '1', '1', '0', '0', '0' },
    new char[] { '1', '1', '0', '0', '0' },
    new char[] { '0', '0', '1', '0', '0' },
    new char[] { '0', '0', '0', '1', '1' }
};

Console.WriteLine(solution.NumIslands(grid));
