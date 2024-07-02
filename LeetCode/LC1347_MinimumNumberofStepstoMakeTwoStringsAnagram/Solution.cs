namespace LC1347_MinimumNumberofStepstoMakeTwoStringsAnagram;
public class Solution
{
    public int MinSteps(string s, string t)
    {
        int[] frequencys = new int[26];
        int[] frequencyt = new int[26];
        int result = 0;

        foreach (char c in s)
        {
            frequencys[c - 'a']++;
        }

        foreach (char c in t)
        {
            frequencyt[c - 'a']++;
        }

        for (int i = 0, j=0; i < frequencys.Length; i++, j++)
        {
            if (frequencys[i] < frequencyt[j])
            {
                result += Math.Abs(frequencyt[i] - frequencys[j]);
            }
        }

        return result;
    }
}
