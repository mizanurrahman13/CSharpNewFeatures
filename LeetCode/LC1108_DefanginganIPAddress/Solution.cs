using System.Text;

namespace LC1108_DefanginganIPAddress;
public class Solution
{
    public string DefangIPaddr(string address)
    {
        StringBuilder stringBuilder = new StringBuilder();

        foreach (char c in address)
        {
            if (c == '.')
                stringBuilder.Append("[.]");
            else
                stringBuilder.Append(c);
        }

        return stringBuilder.ToString();
    }
}
