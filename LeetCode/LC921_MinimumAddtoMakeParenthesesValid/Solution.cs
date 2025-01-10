namespace LC921_MinimumAddtoMakeParenthesesValid;
public class Solution
{
    public int MinAddToMakeValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
                stack.Push(s[i]);
            if (s[i] == ')')
            {                
                if (stack.Count > 0 && stack.Peek() == '(')
                    stack.Pop();
                else
                    stack.Push(s[i]);
            }                
        }

        return stack.Count;
    }
}
