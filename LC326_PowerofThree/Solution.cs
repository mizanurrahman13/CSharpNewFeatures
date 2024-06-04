namespace LC326_PowerofThree;

public class Solution
{
    public bool IsPowerOfThree(int n)
    {
        if (n == 0)
            return false;

        while (n != 1)
        {
            int remainder = n % 3;
            if (remainder != 0)
                return false;
            n /= 3;
        }

        return true;
    }
}
