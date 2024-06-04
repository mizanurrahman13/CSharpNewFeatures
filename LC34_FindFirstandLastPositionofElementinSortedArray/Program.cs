using LC34_FindFirstandLastPositionofElementinSortedArray;
using System.Diagnostics;

Solution solution = new Solution();

//int[] nums = new int[] { 5, 7, 7, 8, 8, 10 };
int[] nums = new int[] { 5, 7, 7, 8, 8, 10 };
int target = 6;

var result = solution.SearchRange(nums, target);

for (int i = 0; i < result.Length; i++)
    Console.WriteLine(result[i]);
