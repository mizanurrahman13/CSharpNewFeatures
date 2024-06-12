namespace LC172_FactorialTrailingZeroes;

public class Solution
{
    //public int TrailingZeroes(int n)
    //{
    //    int count = 0;
    //    while (n > 0)
    //    {
    //        n /= 5;
    //        count += n;
    //    }

    //    return count;
    //}

    public int TrailingZeroes(int n)
    {
        int countOfFives = 0;
        for (int i = 5; i <= n; i *= 5)
        {
            countOfFives += n / i;
        }
        return countOfFives;
    }
}
