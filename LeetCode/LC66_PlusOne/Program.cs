using LC66_PlusOne;

Solution solution = new Solution();

int[] digist = new int[] { 4, 3, 2, 1 };

//int[] digist = new int[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9
//    , 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 };

var result = solution.PlusOne(digist);
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}
