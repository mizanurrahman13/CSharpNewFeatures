namespace LC18_4Sum;

public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        List<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;
            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1])
                    continue;

                long toFind = (long)target - (nums[j] + nums[i]);
                int low = j + 1;
                int high = nums.Length - 1;

                while (low < high)
                {
                    long sum = nums[low] + nums[high];
                    if (sum == toFind)
                    {
                        result.Add([nums[i], nums[j], nums[low], nums[high]]);
                        while (low < high && nums[low] == nums[low - 1])
                            low++;
                        while (low < high && nums[high] == nums[high - 1])
                            high--;
                    }

                    if (sum < toFind)
                        low++;
                    else
                        high--;
                }
            }
        }

        return result;
    }
}