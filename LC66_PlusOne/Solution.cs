namespace LC66_PlusOne;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int index = digits.Length - 1;
        digits[index]++;

        while (digits[index] == 10)
        {
            digits[index] = 0;
            index--;
            if(index != -1)
            {
                digits[index]++;
            }
            else
            {
                digits[0] = 1;
                digits = digits.Concat(new int[] { 0 }).ToArray();
                break;
            }
        }

        return digits;
    }
}
