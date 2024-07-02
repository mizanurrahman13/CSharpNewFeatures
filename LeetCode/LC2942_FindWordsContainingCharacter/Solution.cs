namespace LC2942_FindWordsContainingCharacter;
public class Solution
{
    public IList<int> FindWordsContaining(string[] words, char x)
    {
        int index = 0;
        IList<int> list = new List<int>();

        foreach (string word in words)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == x)
                {
                    list.Add(index);
                    break;

                }
            }
            index++;
        }

        return list;
    }
}
