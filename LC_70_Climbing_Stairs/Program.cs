
var demo = new Solution();
int inputValues = int.Parse(Console.ReadLine());

int n = 4;
int[] dp = new int[inputValues + 1];
//for (int i = 0; i < inputValues + 1; i++)
//{
//    dp[i] = -1;
//}
//Console.Write("Number of ways = "
//              + demo.ClimbStairs(inputValues, dp));
Console.Write("Number of ways = "
              + demo.ClimbStairs(inputValues));
