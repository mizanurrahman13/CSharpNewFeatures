using LC22_GenerateParentheses;

Solution solution = new Solution();

int n = 3;

var result = solution.GenerateParenthesis(n);

foreach (var item in result)
    Console.WriteLine(item);

