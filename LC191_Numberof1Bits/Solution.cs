namespace LC191_Numberof1Bits;
public class Solution
{
    public int HammingWeight(int n)
    {
        string binary = string.Empty;
        int setBitCount = 0;

        while (n > 0)
        {
            int reminder = n % 2;
            if (reminder == 1)
                setBitCount++;
            binary += reminder;
            n /= 2;
        }

        return setBitCount;
    }
}

