namespace LC75_SortColors;

public class Solution
{
    public void SortColors(int[] nums)
    {
        if (nums is null || nums.Length == 0)
            return;

        var (index, left, right) = (0, 0, nums.Length - 1);

        while (index <= right)
        {
            if (nums[index] == 0)
            {
                Swap(left, index);
                left++;
            }
            else if (nums[index] == 2) 
            {
                Swap(index, right);
                right--;
                index--;
            }
            index++;
        }

        void Swap(int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }    
}
