namespace CSharp14;

public class ImplicitSpanConversion
{
    public void ProcessData(ReadOnlySpan<int> data)
    {
        Console.WriteLine(data.Length);
    }
}
