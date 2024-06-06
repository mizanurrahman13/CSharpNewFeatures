using LC1929_ConcatenationofArray;

Solution solution = new Solution();

int[] nums = new int[] { 1, 2, 1 };

var result = solution.GetConcatenation(nums);
foreach (int i in result)
    Console.Write($"{i} ");
