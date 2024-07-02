namespace LC90_SubsetsII;

public class Solution
{
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums);
        IList<IList<int>>subSets = new List<IList<int>>();
        Helper(0, subSets, new List<int>(), nums);

        return subSets;
    }

    private void Helper(int index, IList<IList<int>> subSets, List<int> list, int[] nums)
    {
        subSets.Add(new List<int>(list));

        for (int i = index; i < nums.Length; i++)
        {
            if (i > index && nums[i] == nums[i - 1])
                continue;

            list.Add(nums[i]);
            Helper(i + 1, subSets, list, nums);
            list.RemoveAt(list.Count - 1);
        }
    }
}
