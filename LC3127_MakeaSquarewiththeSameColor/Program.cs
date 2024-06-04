using LC3127_MakeaSquarewiththeSameColor;

Solution solution = new Solution();

char[][] grid = new char[][]
{
    new char[] { 'B', 'W', 'B' },
    new char[] { 'B', 'W', 'B' }
};

Console.WriteLine(solution.CanMakeSquare(grid));
