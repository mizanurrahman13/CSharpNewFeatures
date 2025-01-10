namespace LC_88_MergeSortedArray;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        nums1 = new int[(n + m)+1];

        for (int i = 0; i < nums2.Length; i++)
        {
            nums1[i] += nums2[i];
        }

        foreach (var item in nums1)
        {
            Console.WriteLine(item);
        }
    }
}
