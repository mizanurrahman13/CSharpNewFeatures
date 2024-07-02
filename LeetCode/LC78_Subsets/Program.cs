using LC78_Subsets;

Solution solution = new Solution();

int[] nums = [1, 2, 3];

var result = solution.Subsets(nums);

foreach (var sublist in result)
    Console.WriteLine($"[{string.Join(", ", sublist)}]");

