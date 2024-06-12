namespace LC128_LongestConsecutiveSequence;

public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        SortedSet<int> set = new SortedSet<int>(nums);
        int maxCount = 0;
        int previousValue = Int32.MinValue;
        int count = 0;

        foreach (int num in set)
        {
            if (num == previousValue + 1)
                count++;
            else
                count = 1;
                
            maxCount = Math.Max(count, maxCount);
            previousValue = num;
        }

        return maxCount;
    }
}
