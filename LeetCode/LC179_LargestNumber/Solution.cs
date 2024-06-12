using System.Text;

namespace LC179_LargestNumber;

public class Solution
{
    public string LargestNumber(int[] nums)
    {
        if (IsAllZeros(nums))
            return "0";

        string[] sortedNums = new string[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            sortedNums[i] = $"{nums[i]}";
        }

        Array.Sort(sortedNums, (a, b) => (b + a).CompareTo(a + b));
        StringBuilder stringBuilder = new StringBuilder();

        foreach (string num in sortedNums)
            stringBuilder.Append(num);

        return stringBuilder.ToString();
    }

    private bool IsAllZeros(int[] nums)
    {
        foreach (int i in nums)
        {
            if (i != 0)
                return false;
        }

        return true;
    }
}
