using System.Linq;

namespace LC22_GenerateParentheses;

public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        List<string> list = new List<string>();
        Stack<string> stack = new Stack<string>();
        BuildList(list, "", 0, 0, n);

        //void Backtrack(int openParenthesis, int closeParenthesis)
        //{
        //    if (openParenthesis == n && closeParenthesis == n)
        //    {
        //        list.AddRange(stack);
        //        return;
        //    }

        //    if (openParenthesis < n)
        //    {
        //        stack.Push("(");
        //        Backtrack(openParenthesis + 1, closeParenthesis);
        //        stack.Pop();
        //    }

        //    if (closeParenthesis < openParenthesis && stack.Count > 0)
        //    {
        //        stack.Pop();
        //        Backtrack(openParenthesis, closeParenthesis + 1);
        //        stack.Push("(");
        //    }
        //}

        //Backtrack(0, 0);

        return list;
    }

    private void BuildList(IList<string> list, string currentString, int openParenthesis, int closeParenthesis, int n)
    {
        if (currentString.Length == 2 * n)
        {
            list.Add(currentString);
            return;
        }

        if (openParenthesis < n)
            BuildList(list, currentString + "(", openParenthesis + 1, closeParenthesis, n);

        if (closeParenthesis < openParenthesis)
            BuildList(list, currentString + ")", openParenthesis, closeParenthesis + 1, n);
    }
}
