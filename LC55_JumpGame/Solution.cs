namespace LC55_JumpGame;

public class Solution
{
    public bool CanJump(int[] nums)
    {
        int finalIndex = nums.Length - 1;

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (i + nums[i] >= finalIndex)
            {
                if (i == 0)
                    return true;
                finalIndex = i;
            }               
        }

        return false;
    }
}
