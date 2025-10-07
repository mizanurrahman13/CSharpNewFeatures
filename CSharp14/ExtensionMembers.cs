namespace CSharp14;

public static class EnumerableExtensions
{
    // The "old" extension member syntax still works in .NET 10 and C#14
    public static bool IsEmpty<T>(this IEnumerable<T> target)
        => !target.Any();
}

public static class NewEnumerableExtensions
{
    // 👇 extension block with type parameters and receiver parameter
    extension<T>(IEnumerable<T> target)
    {
        //   👇 no static modifier
        public bool IsEmpty() => !target.Any();
        //                 👆 'this' receiver parameter  removed

    }
}


public static class StringExtensions
{
    // 👇 Extension block specifies receiver type and target parameter
    extension(string target)
    {
        // 👇 You can just write the property like you'd write a "normal" property
        public bool IsAscii
            => target.All(x => char.IsAscii(x));
        //    👆 You can access the receive paramter because it's an instance extension
    }
}
//string someValue = "something";
//bool isAscii = someValue.IsAscii; // 👈 Access the instance extension property on a variable

static class PathExtensions
{
    extension(string)
    {
        public static string operator /(string left, string right)
            => Path.Combine(left, right);
    }
}
//var fullPath = "part1" / "part2" / "test.txt"; // "part1/part2/test.txt"
