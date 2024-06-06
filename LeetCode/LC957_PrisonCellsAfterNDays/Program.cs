using LC957_PrisonCellsAfterNDays;

Solution solution = new Solution();

//int[] cells = new int[] { 0, 1, 0, 1, 1, 0, 0, 1 };
int[] cells = new int[] { 1, 0, 0, 1, 0, 0, 1, 0 };
int n = 1000000000;

var array = solution.PrisonAfterNDays(cells, n);

foreach (var cell in array)
    Console.Write($"{cell} ");

