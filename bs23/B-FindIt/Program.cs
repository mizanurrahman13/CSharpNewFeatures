
/**
 * It's an time and space optimization approach to apply proper datastructure
 * 
 **/
public class Program
{
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        HashSet<int> set = new HashSet<int>();
        HashSet<int> inputSet = new HashSet<int>();
        for (int i = 1; i <= n; i++)
        {
            set.Add(i);
        }
        for (int i = 1; i < n; i++)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (set.Contains(a))
            {
                set.Remove(a);
            }
        }
        foreach (var item in set)
        {
            Console.WriteLine(item);
        }
    }
}
