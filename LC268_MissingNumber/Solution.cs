namespace LC268_MissingNumber;

public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int result = 0;
        int guessSum = 0;
        int actualSum = 0;
        for (int i =  0; i < nums.Length; i++)
        {
            actualSum += nums[i];
        }
        for (int i = 0; i <= nums.Length; i++)
        {
            guessSum += i;
        }

        return guessSum - actualSum;
    }
}
