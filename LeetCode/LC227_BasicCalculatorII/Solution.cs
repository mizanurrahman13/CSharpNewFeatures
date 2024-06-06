namespace LC227_BasicCalculatorII;

public class Solution
{
    public int Calculate(string s)
    {
        int result = 0;
        int current = 0;
        int previous = 0;
        string current_operation = "+";

        s = s.Trim();
        s = s.Replace(" ", "");
        s += "+"; 

        for (int index = 0; index < s.Length; index++)
        {
            char current_char = s[index];
            if (char.IsDigit(s[index]))
            {
                current = current * 10 + (s[index]-'0');
            }
            else
            {
                if (current_operation == "+")
                {
                    result += current;
                    previous = current;
                }
                else if (current_operation == "-")
                {
                    result -= current;
                    previous = -current;
                }
                else if (current_operation == "*")
                {
                    result -= previous;
                    result += previous * current;
                    previous = current * previous;
                }
                else if (current_operation == "/")
                {
                    result -= previous;
                    result += previous / current;
                    previous = previous / current;
                }
                current = 0;
                current_operation = current_char.ToString();
            }
        }

        return result;
    }
}
