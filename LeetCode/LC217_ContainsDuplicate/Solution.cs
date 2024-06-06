namespace LC217_ContainsDuplicate;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        //Array.Sort(nums);
        //for (int i = 0; i < nums.Length - 1; i++)
        //{
        //    if (nums[i] == nums[i + 1])
        //        return true;
        //}

        //return false;
        HashSet<int> myhash = new HashSet<int>();
        foreach (var item in nums)
        {
            if (myhash.Contains(item))
            {
                return true;
            }
            myhash.Add(item);
        }
        return false;
    }
}
