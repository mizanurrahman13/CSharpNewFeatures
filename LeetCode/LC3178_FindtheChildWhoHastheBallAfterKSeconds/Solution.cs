namespace LC3178_FindtheChildWhoHastheBallAfterKSeconds;

public class Solution
{
    public int NumberOfChild(int n, int k)
    {
        int result = 0;
        k = k % (2 * (n - 1));

        if (k <= n - 1)
            return k;
        else          
            result = (2 * (n - 1)) - k;

        return result;
    }
}
