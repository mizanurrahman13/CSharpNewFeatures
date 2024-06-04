using LC18_4Sum;

Solution solution = new Solution();

int[] nums = new int[] { 1, 0, -1, 0, -2, 2 };
int target = 0;

var result = solution.FourSum(nums, target);

foreach (var item in result)
{
    foreach (var i in item)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}
    

    
