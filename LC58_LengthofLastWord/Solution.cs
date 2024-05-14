public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int finalWordLength = 0;
        int i = s.Length - 1;
        while(i>= 0 && s[i] == ' ')
            i -= 1;
        while (i >= 0 && s[i] != ' ')
        {
            finalWordLength++;
            i -= 1;
        }            

        return finalWordLength;
    }
}