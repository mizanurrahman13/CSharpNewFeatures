/**
 * It's an add hok implementation approch
 * 
 **/
public class Program
{
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            count = 0;
            string over = Console.ReadLine();
            for (int j = 0; j < over.Length; j++)
            {
                if (over[j] >= 48 && over[j] <= 53)
                {
                    count++;
                }
            }
            if (count > 6)
            {
                Console.WriteLine($"{count / 6} OVER {count % 6} BALL");
            }
            else if (count == 6)
            {
                Console.WriteLine($"{count / 6} OVER");
            }
            else
                Console.WriteLine($"{count} BALL");
        }
    }
}