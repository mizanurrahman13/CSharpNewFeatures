namespace LC136_SingleNumber;

public class Solution
{
    public int SingleNumber(int[] nums)
    {
        Array.Sort(nums);
        //int huntedNumber = 0;
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    huntedNumber ^= nums[i];                 
        //}

        //return huntedNumber;
        for (int i = 0; i < nums.Length; i = i + 2)
        {
            if (i == nums.Length - 1) return nums[i];
            if (nums[i] != nums[i + 1]) return nums[i];
        }
        return 0;
    }
}
