namespace CSharp13;

public static class LINQAggregateBy
{
    public static Dictionary<TKey, TResult> AggregateBy<TSource, TKey, TResult>(
        this IEnumerable<TSource> source,
        Func<TSource, TKey> keySelector,
        Func<TKey, TResult> seedFactory,
        Func<TResult, TSource, TResult> aggregator)
    {
        var result = new Dictionary<TKey, TResult>();

        foreach (var item in source)
        {
            var key = keySelector(item);

            if (!result.ContainsKey(key))
            {
                result[key] = seedFactory(key);
            }

            result[key] = aggregator(result[key], item);
        }

        return result;
    }
}

public record ListenedSong(long SongId, string SongName, long SongDurationSeconds);

