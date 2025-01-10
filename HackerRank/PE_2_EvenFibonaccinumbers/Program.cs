using System.Diagnostics.CodeAnalysis;

internal class Program
{
    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            long n = Convert.ToInt64(Console.ReadLine());
            long sum = 0;
            long firstNumber = 1;
            long secondNumber = 1;
            long nextNumber = 0;

            while (nextNumber < 4000000)
            {                
                if (nextNumber % 2 == 0 && nextNumber <= n)
                    sum += nextNumber;
                nextNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
            Console.WriteLine(sum);
        }
    }
}