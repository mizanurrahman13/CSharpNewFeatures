namespace LC1929_ConcatenationofArray;

public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        int[] result = new int[2*nums.Length];
        int length = nums.Length;

        for (int i = 0; i < length; i++)
        {
            result[i] = nums[i];
            result[i + length] = nums[i];
        }

        return result;
    }
}
