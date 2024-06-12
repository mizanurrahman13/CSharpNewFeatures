namespace LC3179_FindtheNthValueAfterKSeconds;

public class Solution
{
    public int ValueAfterKSeconds(int n, int k)
    {
        int[] dp = new int[n];
        for (int i = 0; i < n; i++)
            dp[i] = 1;

        int moduloValue = 1_000_000_007;
        for (int i = 1; i <=k ; i++)
        {
            for (int j = 1; j < n; j++)
            {
                dp[j] = ((dp[j - 1]) % moduloValue + (dp[j]) % moduloValue)%moduloValue;
            }
        }

        return dp[n-1]%moduloValue;
    }
}
