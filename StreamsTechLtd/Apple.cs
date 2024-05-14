// See https://aka.ms/new-console-template for more information
public class Apple
{
    private static int Count = 0;

    public Apple()
    {
        Count++;
    }

    public static int GetCount()
    {
        return Count;
    }
}