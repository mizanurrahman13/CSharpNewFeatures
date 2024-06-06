namespace LC34_FindFirstandLastPositionofElementinSortedArray;

public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int[] result = { -1, -1 };

        // Find the leftmost occurrence
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] >= target)
                right = mid - 1;
            else
                left = mid + 1;
        }
        if (left < nums.Length && nums[left] == target)
            result[0] = left;

        // Find the rightmost occurrence
        left = 0;
        right = nums.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] <= target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        if (right >= 0 && nums[right] == target)
            result[1] = right;

        return result;
    }
}
