namespace LC454_4SumII;

public class Solution
{
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
    {
        Dictionary<int, int> tupleCount = new Dictionary<int, int>();
        int sum = 0;
        int length = nums1.Length;
        int count = 0;

        for (int i = 0; i < length ; i++)
        {
            for (int j = 0; j < length; j++)
            {
                sum = nums1[i] + nums2[j];
                if (!tupleCount.ContainsKey(sum))
                    tupleCount[sum] = 0;

                tupleCount[sum]++;
            }
        }

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                sum = -(nums3[i] + nums4[j]);
                if (!tupleCount.ContainsKey(sum))
                    continue;

                count += tupleCount[sum];
            }
        }

        return count;
    }
}
