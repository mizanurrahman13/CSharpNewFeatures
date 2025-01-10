using PE_1_Multiplesof3and5;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        //int num = 10;

        //Console.WriteLine(solution.Multiples(num));
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            long num = (int)Convert.ToInt64(Console.ReadLine());

            long result = 0;

            for (long i = 0; i < num; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }

            Console.WriteLine(result);
        }
    }
}