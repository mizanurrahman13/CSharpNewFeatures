namespace LC910_RemoveAllOccurrencesofaSubstring;
public class Solution
{
    public string RemoveOccurrences(string s, string part)
    {
        Stack<char> stack = new Stack<char>();
        int lastChar = part.Length - 1;
        
        for (int i = 0; i < s.Length; i++)
        {
            stack.Push(s[i]);
            if (stack.Count >= part.Length && stack.Peek() == part[lastChar])
            {
                int index = lastChar;
                string removed = string.Empty;
                while (index >= 0 && stack.Peek() == part[index])
                {
                    removed = stack.Pop() + removed;
                    index--;
                }

                if (index > -1)
                {
                    foreach (char c in removed)
                        stack.Push(c);
                }
            } 
        }
        string result = string.Empty;
        while (stack.Count > 0)
        {
            result = stack.Pop() + result;
        }

        return result;
    }
}
