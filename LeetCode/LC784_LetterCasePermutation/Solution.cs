using System.Text;

namespace LC784_LetterCasePermutation;
public class Solution
{
    IList<string> result = new List<string>();
    public IList<string> LetterCasePermutation(string s)
    {
        StringBuilder stringBuilder = new StringBuilder(s);

        Helper(stringBuilder, 0);

        return result;
    }

    private void Helper(StringBuilder stringBuilder, int index)
    {
        if (index == stringBuilder.Length)
        {
            result.Add(stringBuilder.ToString());
            return;
        }

        Helper(stringBuilder, index + 1);

        if (char.IsLower(stringBuilder[index]))
        {
            stringBuilder[index] = char.ToUpper(stringBuilder[index]);
            Helper(stringBuilder, index + 1);
        }
        else if (char.IsUpper(stringBuilder[index]))
        {
            stringBuilder[index] = char.ToLower(stringBuilder[index]);
            Helper(stringBuilder, index + 1);
        }
    }
}
