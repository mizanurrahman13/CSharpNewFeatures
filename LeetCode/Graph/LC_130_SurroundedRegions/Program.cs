using LC_130_SurroundedRegions;

char[][] board =
        {
            new char[] { 'X', 'X', 'X', 'X' },
            new char[] { 'X', 'O', 'O', 'X' },
            new char[] { 'X', 'X', 'O', 'X' },
            new char[] { 'X', 'O', 'X', 'X' }
        };

var solver = new Solution();
Console.WriteLine("Before DFS:");
solver.PrintBoard(board);

solver.Solve(board);

Console.WriteLine("\nAfter DFS:");
solver.PrintBoard(board);
