namespace LC1529_MinimumSuffixFlips;
public class Solution
{
    public int MinFlips(string target)
    {
        int count = 0;
        char previous = '0';

        foreach (char item in target)
        {
            if (item != previous)
            {
                count++;
                previous = item;
            }
        }

        return count;
    }
}
