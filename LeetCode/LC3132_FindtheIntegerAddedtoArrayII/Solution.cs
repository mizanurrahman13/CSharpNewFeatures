namespace LC3132_FindtheIntegerAddedtoArrayII;

public class Solution
{
    public int MinimumAddedInteger(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);
        int target = int.MaxValue;

        for (int i = 0; i < 3; i++)
        {
            int x = nums2[0] - nums1[i];

            if (Check(nums1, nums2, x))
                target = Math.Min(target, x);
        }

        return target;
    }

    private bool Check(int[] nums1, int[] nums2, int k)
    {
        int count = 0;
        int j = 0;
        for (int i = 0; i < nums1.Length && j < nums2.Length; i++)
        {
            if (nums1[i] + k != nums2[j])
                count++;
            else
                j++;
        }

        if (count > 2)
            return false;

        return true;
    }
}
