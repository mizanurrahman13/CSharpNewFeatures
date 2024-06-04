namespace LC169_MajorityElement;

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int huntingNumber = 0;
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (count == 0)
            {
                huntingNumber = nums[i];
            }
            if (nums[i] == huntingNumber)
                count++;
            else
                count--;
        }

        return huntingNumber;
    }
}
