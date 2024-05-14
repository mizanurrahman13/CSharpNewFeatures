using System.Text;

namespace LC67_AddBinary;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        int carry = 0;
        StringBuilder stringBuilder = new StringBuilder();        

        for(int i = a.Length - 1, j = b.Length - 1; i>=0 || j>=0; i--, j--)
        {
            var x = i >= 0 ? a[i] - '0' : 0;
            var y = j >= 0 ? a[j] - '0' : 0;

            var sum = x + y + carry;
            if(sum > 1)
            {
                stringBuilder.Insert(0, sum % 2);
                carry = 1;
            }
            else
            {
                stringBuilder.Insert(0, sum);
                carry = 0;
            }
        }
        if (carry == 1)
            stringBuilder.Insert(0, '1');
        return stringBuilder.ToString();

    }
}
