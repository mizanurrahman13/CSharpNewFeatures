namespace CSharp13;

public static class LINQIndex
{
    public static IEnumerable<(int Index, T Item)> WithIndex<T>(this IEnumerable<T> source)
    {
        int index = 0;
        foreach (var item in source)
        {
            yield return (index++, item);
        }
    }
}

public record Song(string Name, int ReleaseYear, string Artist);

