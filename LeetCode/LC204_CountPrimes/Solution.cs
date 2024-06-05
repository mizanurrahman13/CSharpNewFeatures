namespace LC204_CountPrimes;

public class Solution
{
    public int CountPrimes(int n)
    {
        if (n <= 2)
            return 0;

        bool[] isPrime = new bool[n];
        for (int i = 2; i < n; i++)
            isPrime[i] = true;

        // Mark multiples of each prime as not prime
        for (int p = 2; p * p < n; p++)
        {
            if (isPrime[p])
            {
                for (int i = p * p; i < n; i+=p)
                    isPrime[i] = false;
            }
        }

        int count = 0;
        for (int i = 2; i < n; i++)
        {
            if (isPrime[i])
                count++;
        }

        return count;
    }
}
