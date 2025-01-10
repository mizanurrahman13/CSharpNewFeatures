namespace LC2023_NumberofPairsofStringsWithConcatenationEqualtoTarget;
public class Solution
{
    public int NumOfPairs(string[] nums, string target)
    {
        int count = 0;

        for (int i = 0; i < nums.Length; i++) 
        {
            for (int j = i+1; j < nums.Length; j++) 
            { 
                if (nums[i] + nums[j] == target)
                {
                    count++;
                }
                if (nums[j] + nums[i] == target)
                {
                    count++;
                }
            }    
        }

        return count;
    }
}
