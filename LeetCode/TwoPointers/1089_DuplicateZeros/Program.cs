using _1089_DuplicateZeros;

int[] arr = { 1, 0, 2, 3, 0, 4, 5, 0 };
Solution solution = new Solution();
solution.DuplicateZeros(arr);

Console.WriteLine(string.Join(", ", arr));
// Output: 1, 0, 0, 2, 3, 0, 0, 4
