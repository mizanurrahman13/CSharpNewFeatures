using LC15_3Sum;

Solution solution = new Solution();

int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };

var result = solution.ThreeSum(nums);

foreach (var item in result)
{
    foreach (var i in item)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}
