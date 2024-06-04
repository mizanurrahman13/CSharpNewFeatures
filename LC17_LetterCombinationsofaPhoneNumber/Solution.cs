namespace LC17_LetterCombinationsofaPhoneNumber;

public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        Dictionary<char, string> phone = new Dictionary<char, string>();

        phone.Add('2', "abc");
        phone.Add('3', "def");
        phone.Add('4', "ghi");
        phone.Add('5', "jkl");
        phone.Add('6', "mno");
        phone.Add('7', "pqrs");
        phone.Add('8', "tuv");
        phone.Add('9', "wxyz");

        List<string> result = new List<string>();
        if (digits.Length == 0)
            return result;
        Search("", digits, 0, phone, result);

        return result;
    }

    private void Search(string combination, string digits, int index, Dictionary<char,string> phone, List<string> result)
    {
        if (index == digits.Length)
        {
            result.Add(combination);
            return;
        }

        string letters = phone[digits[index]];
        foreach (char letter in letters)
        {
            Search(combination + letter, digits, index + 1, phone, result);
        }
    }
}
