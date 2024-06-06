namespace LC28_FindtheIndexoftheFirstOccurrenceinaString;

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        int hayStackLength = haystack.Length;
        int neddleLength = needle.Length;
        int neddleLengthCount = needle.Length;
        int firstIndex = 0;

        string subString = haystack.Substring(firstIndex, neddleLength);

        for(int i = 0; i < hayStackLength; i++)
        {
            for(int j = 0; j < neddleLength; j++)
            {
                if (haystack[i] == needle[j] && neddleLengthCount != 0)
                {
                    firstIndex = i;
                    neddleLengthCount--;
                }
            }
        }

        return firstIndex;
    }
}
