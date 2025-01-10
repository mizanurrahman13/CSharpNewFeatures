namespace PE_1_Multiplesof3and5;
public class Solution
{
    public int Multiples(int number)
    {
        int result = 0;

        for (int i = 0; i < number; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                result += i;
            }
        }

        return result;
    }
}
