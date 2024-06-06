using LC347_TopKFrequentElements;

Solution solution = new Solution();

int[] nums = new int[] { 1, 1, 1, 2, 2, 3 };
int k = 2;

var result = solution.TopKFrequent(nums, k);

foreach (int x in result)
    Console.Write($"{x} ");
    
