namespace LC46_Permutations;

public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Permutation(nums, new List<int>(), result);

        return result;
    }

    private void Permutation(int[] nums, List<int> path, IList<IList<int>> result)
    {
        if (path.Count == nums.Length)
        {
            result.Add(new  List<int>(path));
            return;
        }

        foreach (int item in nums)
        {
            if (path.Contains(item))
                continue;
            path.Add(item);
            Permutation(nums, path, result);
            path.RemoveAt(path.Count - 1);
        }
    }
}