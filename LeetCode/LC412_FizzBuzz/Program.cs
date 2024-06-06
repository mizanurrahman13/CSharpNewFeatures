using LC412_FizzBuzz;

Solution solution = new Solution();

int num = 5;

var list = solution.FizzBuzz(num);
 
Console.WriteLine(solution.FizzBuzz(num));

foreach (var item in list)
{
    Console.WriteLine(item);
}
