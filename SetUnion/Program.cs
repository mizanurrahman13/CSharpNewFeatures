using SetUnion;

Solution solution = new Solution();

int[] nums1 = new int[] { 1, 3, 5, 7, 8 };
int[] nums2 = new int[] { 2, 3, 4, 7, 9 };

var result = solution.SetUnionDemo(nums1, nums2);

foreach (int i in result)
    Console.Write($"{i} ");
