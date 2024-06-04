using System.Collections.Generic;

namespace SetUnion
{
    public class Solution
    {
        public int[] SetUnionDemo(int[] nums1, int[] nums2)
        {
            int[] unionSet = new int[nums1.Length+nums2.Length];
            //unionSet = nums1.Union(nums2).ToArray();
            //Array.Sort(unionSet);
            //return unionSet;
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (set.Contains(nums1[i]))
                    continue;
                else
                    set.Add(nums1[i]);
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                if (set.Contains(nums2[i]))
                    continue;
                else
                    set.Add(nums2[i]);
            }

            var sortedSet = set.OrderBy(item => item);

            return sortedSet.ToArray();
        }
    }
}
