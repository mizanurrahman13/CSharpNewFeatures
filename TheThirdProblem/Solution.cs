namespace TheThirdProblem;

public class Solution
{
    public int Method(int[] nums)
    {
        int result = 0;
        if (nums.Length >= 3)
            result = nums[2];

        return result;
    }
}
