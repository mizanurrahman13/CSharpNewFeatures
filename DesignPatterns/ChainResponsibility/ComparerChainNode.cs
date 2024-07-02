public class ComparerChainNode<T> : IComparer<T>
{
    private IComparer<T> First { get; }
    private IComparer<T> Next { get; }

    public ComparerChainNode(IComparer<T> first, IComparer<T> next) =>
        (First, Next) = (first, next);

    public int Compare(T? x, T? y) =>
        First.Compare(x, y) is int decision && decision != 0 ? decision: Next.Compare(x, y);
}

public static class ComparerChainNode
{
    public static IComparer<T> Then<T>(this IComparer<T> first, IComparer<T> next) =>
        new ComparerChainNode<T>(first, next);
}