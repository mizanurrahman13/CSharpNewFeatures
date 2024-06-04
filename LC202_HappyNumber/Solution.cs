namespace LC202_HappyNumber;

public class Solution
{
    public bool IsHappy(int n)
    {
        bool isHappy = false;
        List<int> list = new List<int>();
        int result = 0;
        while (n > 0)
        {
            result = 0;
            while (n > 0)
            {
                int reminder = n % 10;
                result += (reminder * reminder);
                n /= 10;
                
            }

            if (list.Contains(result))
                return false;
            else
                list.Add(result);

            if (result == 1)
                return true;

            n = result;
        }

        return false;
    }
}