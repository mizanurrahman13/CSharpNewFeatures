/**
 * I think it's a power calculation problem with big number of output
 * 
 **/
public class Program
{
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        var result = (Math.Pow(n, 2)-1)%(Math.Pow(10, 9)+7);
        Console.WriteLine(result);
    }
}