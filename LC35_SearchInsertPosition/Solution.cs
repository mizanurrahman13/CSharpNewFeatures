namespace LC35_SearchInsertPosition;

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int result = 0;
        int lastNum = nums[nums.Length - 1];
        for (int i = 0; i < nums.Length; i++)
        {
            if (target > lastNum)
            {
                result = nums.Length;
                break;
            }
            if (nums[i] == target) 
            {
                result = i;
                break;
            }
            if(target > nums[i] && target < nums[i+1])
            {
                result = i+1; 
                break;
            }            
        }

        return result;
    }
}
