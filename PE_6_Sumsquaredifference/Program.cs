
internal class Program
{
    private static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            long sqrtNumber = 0;
            long naturalNumber = 0;
            long result = 0;

            for (int i = 1; i <= n; i++)
            {
                naturalNumber += i;
            }
            naturalNumber = (naturalNumber * naturalNumber);

            for (int i = 1; i <= n; i++)
            {
                sqrtNumber += i*i;
            }

            Console.WriteLine(naturalNumber - sqrtNumber);
        }        
    }
}