namespace LC171_ExcelSheetColumnNumber;

public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        Dictionary<char, int> columnName = new Dictionary<char, int>();
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        for (int i = 0; i <26; i++)
        {
            columnName.Add(alpha[i], i+1);
        }

        string reversedcolumnTitle = string.Empty;
        for (int i = columnTitle.Length - 1; i > -1; i--)
        {
            reversedcolumnTitle += columnTitle[i];
        }

        int result = 0;
        for (int i = 0; i < reversedcolumnTitle.Length; i++)
        {
            char letter = reversedcolumnTitle[i];
            int value = columnName.ContainsKey(letter) ? columnName[letter] : 0;
            result += (value * (int)Math.Pow(26, i));
        }

        return result;
    }
}
