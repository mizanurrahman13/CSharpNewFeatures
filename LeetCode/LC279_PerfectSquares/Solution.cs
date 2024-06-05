namespace LC279_PerfectSquares;

public class Solution
{
    public int NumSquares(int n)
    {
        int[] dp = new int[n + 1];

        Array.Fill(dp, n + 1);
        dp[0] = 0;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j * j <= i;  j++)
            {
                dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
            }
        }

        return dp[n];
    }

    //public int NumSquares(int n)
    //{
    //    if (n <= 0) return 0;

    //    Queue<int> queue = new Queue<int>();
    //    HashSet<int> visited = new HashSet<int>();

    //    queue.Enqueue(n);
    //    visited.Add(n);

    //    int depth = 0;

    //    while (queue.Count > 0)
    //    {
    //        int size = queue.Count;

    //        for (int i = 0; i < size; i++)
    //        {
    //            int current = queue.Dequeue();

    //            if (current == 0)
    //            {
    //                return depth;
    //            }

    //            for (int j = 1; j * j <= current; j++)
    //            {
    //                int next = current - j * j;

    //                if (!visited.Contains(next))
    //                {
    //                    queue.Enqueue(next);
    //                    visited.Add(next);
    //                }
    //            }
    //        }

    //        depth++;
    //    }

    //    return -1;
    //}
}
