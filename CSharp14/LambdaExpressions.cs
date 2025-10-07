namespace CSharp14;

public class LambdaExpressions
{
    public delegate bool TryParse<T>(string text, out T result);

    public TryParse<int> parse = (string text, out int result) => int.TryParse(text, out result);
}