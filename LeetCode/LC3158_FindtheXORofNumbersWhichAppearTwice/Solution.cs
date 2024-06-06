namespace LC3158_FindtheXORofNumbersWhichAppearTwice;

public class Solution
{
    public int DuplicateNumbersXOR(int[] nums)
    {
        HashSet<int> list = new HashSet<int>();

        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                if (list.Contains(nums[i]))
                    continue;
                else
                    list.Add(nums[i]);
            }
        }

        int result = 0;
        foreach(int item in list)
        {
            result = result^item;
        }

        return result;
    }
}
