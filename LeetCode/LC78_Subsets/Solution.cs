namespace LC78_Subsets;

public class Solution
{
    int[] num;
    IList<IList<int>> result;
    public IList<IList<int>> Subsets(int[] nums)
    {
        result = new List<IList<int>>();
        result.Add(new List<int>());
        num = nums;

        for (int i = 0; i < num.Length; i++)
            helper(i + 1, new List<int>() { nums[i] });

        return result;
    }

    private void helper(int i, List<int> list)
    {
        result.Add(list);

        if (i >= num.Length)
            return;

        for (int j = i; j < num.Length; j++)
        {
            List<int> copy = new List<int>(list);
            copy.Add(num[j]);
            helper(j + 1, copy);
        }
    }
}
