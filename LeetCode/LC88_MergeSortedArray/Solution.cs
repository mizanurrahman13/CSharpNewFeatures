namespace LC88_MergeSortedArray;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        while (j >= 0)
        {
            if (i < 0 || nums2[j] > nums1[i])
            {
                nums1[k] = nums2[j];
                j--;
            }
            else
            {
                nums1[k] = nums1[i];
                i--;
            }
            k--;
        }

        //List<int> mergedList = new List<int>();

        //for(int i =  0; i < m; i++)
        //{
        //    mergedList.Add(nums1[i]);
        //}

        //for (int i = 0; i < n; i++)
        //{
        //    mergedList.Add(nums2[i]);
        //}
        //mergedList.Sort();        
    }
}
