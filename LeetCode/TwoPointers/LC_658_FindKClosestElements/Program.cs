using LC_658_FindKClosestElements;

var solution = new Solution();
int[] arr = { 1, 2, 3, 4, 5 };
int k = 4, x = 3;

var result = solution.FindClosestElements(arr, k, x);
Console.WriteLine(string.Join(", ", result)); // Output: 1, 2, 3, 4
