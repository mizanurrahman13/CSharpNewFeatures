using LC238_ProductofArrayExceptSelf;

Solution solution = new Solution();

//int[] nums = new int[] { 1, 2, 3, 4 };
int[] nums = new int[] { -1, 1, 0, -3, 3 };

var result = solution.ProductExceptSelf(nums);

foreach (int i in result)
    Console.WriteLine($"{i} ");
