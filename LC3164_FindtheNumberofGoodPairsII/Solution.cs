namespace LC3164_FindtheNumberofGoodPairsII;

public class Solution
{
    public long NumberOfPairs(int[] nums1, int[] nums2, int k)
    {
        Dictionary<long, long> pairCount = new Dictionary<long, long>();
        foreach (long n2 in nums2)
        {
            if (pairCount.ContainsKey(n2 * k))
                pairCount[n2 * k]++;
            else
                pairCount[n2 * k] = 1;
        }

        long result = 0;
        foreach (long n1 in nums1)
        {
            if (n1 % k == 0)
            {
                double length = Math.Sqrt(n1);
                for (long i = 1; i <= length; i++)
                {
                    if (n1 % i == 0)
                    {
                        if (pairCount.ContainsKey(i))
                            result += pairCount[i];

                        long i2 = n1 / i;
                        if (i != i2)
                            if (pairCount.ContainsKey(i2))
                                result += pairCount[i2];
                    }                    
                }
            }            
        }

        return result;
    }
}
