namespace LC238_ProductofArrayExceptSelf;

public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] result = new int[nums.Length];
        Array.Fill(result, 1);
        int prefix = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = prefix;
            prefix *= nums[i];
        }

        int postfix = 1;
        for (int i =  nums.Length - 1; i > -1; i--)
        {
            result[i] *= postfix;
            postfix *= nums[i];
        }

        return result;
    }
}
