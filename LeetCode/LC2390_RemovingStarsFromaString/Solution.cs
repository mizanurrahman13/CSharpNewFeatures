using System.Text;

namespace LC2390_RemovingStarsFromaString;
public class Solution
{
    public string RemoveStars(string s)
    {
        //var stack = new Stack<char>();
        //var finalStack = new Stack<char>();
        //int count = 0;
        //var reverseString = s.Reverse();

        //foreach (char c in reverseString)
        //{
        //    if (c == '*')
        //        count++;

        //    stack.Push(c);
        //}            

        //while (stack.Count > 0)
        //{
        //    char c = stack.Pop();
        //    if (c == '*')
        //    {
        //        finalStack.Pop();
        //        //stack.Pop();
        //        count--;
        //    }
        //    else
        //        finalStack.Push(c);
        //}

        //var result = "";
        //foreach (char c in finalStack.Reverse())
        //    result += c;

        //return result;

        Stack<char> stack = new Stack<char>();
        foreach (var c in s)
        {
            if (c == '*')
                stack.Pop();
            else
                stack.Push(c);
        }
        StringBuilder stringBuilder = new StringBuilder();
        while (stack.Count > 0)
        {
            stringBuilder.Insert(0, stack.Pop());
        }

        return stringBuilder.ToString();
    }
}
