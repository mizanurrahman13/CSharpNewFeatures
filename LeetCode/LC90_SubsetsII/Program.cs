using LC90_SubsetsII;

Solution solution = new Solution();

int[] nums = [1, 2, 2];

var result = solution.SubsetsWithDup(nums);

foreach (var sublist in result)
    Console.WriteLine($"[{string.Join(", ", sublist)}]");
