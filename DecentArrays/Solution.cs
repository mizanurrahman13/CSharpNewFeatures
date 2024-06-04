namespace DecentArrays;

public class Solution
{
    public string Print(int[] nums)
    {
        for (int i = 0; i < nums.Length-1; i++)
        {
            if (nums[i] > nums[i + 1])
            {
                return "No";
            }
        }

        return "Yes";
    }
}
