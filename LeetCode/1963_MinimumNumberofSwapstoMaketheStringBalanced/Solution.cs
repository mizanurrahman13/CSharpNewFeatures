namespace _1963_MinimumNumberofSwapstoMaketheStringBalanced;
public class Solution
{
    public int MinSwaps(string s)
    {
        int closingBrackets = 0, maxClosingBrackets = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '[')
                closingBrackets--;
            else
                closingBrackets++;
            maxClosingBrackets = Math.Max(maxClosingBrackets, closingBrackets);
        }

        return (maxClosingBrackets + 1) / 2;
    }
}