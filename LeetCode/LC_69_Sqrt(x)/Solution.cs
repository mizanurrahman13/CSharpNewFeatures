public class Solution
{
    public int MySqrt(int x)
    {
        if (x <= 1)
            return x;
        int begin = 1;
        int end = x;
        while (begin < end)
        {
            int mid = begin + (end - begin) / 2;
            int sqrt = x / mid;
            if (sqrt == mid)
                return mid;
            if (sqrt < mid)
                end = mid;
            else
                begin = mid + 1;
        }

        return begin - 1;
    }
}