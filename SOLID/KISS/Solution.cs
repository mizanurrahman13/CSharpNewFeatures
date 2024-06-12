namespace KISS;

/*
 * 💡 𝐊𝐞𝐞𝐩 𝐢𝐭 𝐒𝐢𝐦𝐩𝐥𝐞, 𝐒𝐭𝐮𝐩𝐢𝐝 (𝐊𝐈𝐒𝐒) 𝐏𝐫𝐢𝐧𝐜𝐢𝐩𝐥𝐞

KISS has many different full forms over the internet although, I found this insightful. But don’t worry it’s not important because at the end they all point to one thing and that is keep things simple.

As a developer while looking at PR’s with your lead you would have often heard that why are you writing theses lines , these are un necessary remove it. So indirectly they are  pointing out towards KISS descriptive. 

In few points KISS says

1. Don’t make things complex purposefully , if you can handle a situation in 10 lines of code don’t go for 15 lines approach.

2. Follow Uncle Bob SRP (Single Responsibility Principle) by restricting your classes to Single Responsibility.

3. Keep methods simple don’t go over 20 lines of code per method.

 */
public class Solution
{
    public int Fibonacci1(int n)
    {
        if (n == 0 || n == 1)
            return n;
        else
        {
            int a = 0, b = 1, c = 3;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }

    public int Fibonacci(int n)
    {
        if (n == 0 || n == 1)
            return n;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
