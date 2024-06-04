namespace LC15_3Sum;

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            int toFind = -1 * nums[i];
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int currentSum = nums[left] + nums[right];
                if (currentSum > toFind)
                    right--;
                else if (currentSum < toFind)
                    left++;
                else
                {
                    int leftValue = nums[left];
                    int rightValue = nums[right];
                    result.Add(new List<int> { nums[i], leftValue, rightValue });

                    if (leftValue == rightValue)
                        break;

                    while (left < right && nums[left] == leftValue)
                        left++;

                    while (left < right && nums[right] == rightValue)
                        right--;
                }
            }

            while (i < nums.Length - 2 && nums[i] == nums[i + 1])
                i++;
        }

        return result;
    }
}
