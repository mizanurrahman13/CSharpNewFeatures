namespace LC3131_FindtheIntegerAddedtoArrayI;

public class Solution
{
    public int AddedInteger(int[] nums1, int[] nums2)
    {
        int target = 0;
        Array.Sort(nums1);
        Array.Sort(nums2);
        target = nums2[0] - nums1[0];

        return target;
    }
}
