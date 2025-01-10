
using System.Numerics;

internal class Program
{
    static void Main(string[] args)
    {
        
        int t = Convert.ToInt32(Console.ReadLine());
        string[] numbers = new string[t];
        for (int a0 = 0; a0 < t; a0++)
        {
            string n = Console.ReadLine();

            numbers[a0] = n;            
        }

        BigInteger sum = new BigInteger(0);

        foreach (string number in numbers)
        {
            sum += BigInteger.Parse(number);
        }

        string sumString = sum.ToString();
        string firstTenDigits = sumString.Substring(0, 10);

        Console.WriteLine(firstTenDigits);
    }
}