namespace LC3146_PermutationDifferencebetweenTwoStrings;
public class Solution
{
    public int FindPermutationDifference(string s, string t)
    {
        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < t.Length; j++)
            {
                if (s[i] == t[j])
                    result += Math.Abs(i - j);
            }
        }

        return result;
    }
}