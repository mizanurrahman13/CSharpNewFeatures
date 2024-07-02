using System.Text;

namespace LC1678_GoalParserInterpretation;
public class Solution
{
    public string Interpret(string command)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i <= command.Length - 1; i++)
        {
            if (command[i] == 'G')
                sb.Append('G');
            else if (command[i] == '(' && command[i + 1] == ')')
                sb.Append('o');
            else if (command[i] == '(' && command[i + 1] == 'a')
                sb.Append("al");
        }

        return sb.ToString();
    }
}
