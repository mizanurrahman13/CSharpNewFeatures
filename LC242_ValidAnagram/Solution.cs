namespace LC242_ValidAnagram;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {

        //char[] sorteds = s.ToCharArray();
        //char[] sortedt = t.ToCharArray();

        //Array.Sort(sorteds);
        //Array.Sort(sortedt);

        //if (new string(sorteds) == new string(sortedt))
        //    return true;
        //else
        //    return false;
        int[] alphabet = new int[26];

        if(s.Length != t.Length)
            return false;

        foreach(char c in s)
        {
            alphabet[c - 'a']++;
        }

        foreach(char c in t)
        {
            if (alphabet[c - 'a'] > 0)
                alphabet[c - 'a']--;
            else
                return false;
        }

        return true;
    }
}
