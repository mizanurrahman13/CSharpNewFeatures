namespace LC189_RotateArray;

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        k = k % nums.Length;
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
            left++;
            right--;
        }

        left = 0;
        right = k - 1;
        while (left < right)
        {
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
            left++;
            right--;
        }

        left = k;
        right = nums.Length - 1;
        while (left < right)
        {
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
            left++;
            right--;
        }
    }
}
