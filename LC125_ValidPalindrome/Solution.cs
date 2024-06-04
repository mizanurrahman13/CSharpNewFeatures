namespace LC125_ValidPalindrome;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        string smallS = s.ToLower();
        string tempString = string.Empty;
        for (int i = 0; i < smallS.Length; i++)
        {
            if ((smallS[i] >= 97 && smallS[i] <= 122) || (smallS[i] >= 48 && smallS[i] <= 57))
                tempString += smallS[i];
        }

        string reverseTempString = string.Empty;
        for (int i = tempString.Length - 1; i > -1 ; i--)
        {
            reverseTempString += tempString[i];
        }

        if (tempString == reverseTempString) 
            return true;
        else
            return false;
    }
}
