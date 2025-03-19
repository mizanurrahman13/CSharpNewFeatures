namespace CSharp09;

/// <summary>
/// With init-only setters, you can allow properties to be initialized at the time of object creation but prevents modification after that. This improves immutability.

///You can do this by using the init accessor:
/// </summary>
public class InitOnlySetters
{
    public class Person
    {
        public string Name { get; init; } = string.Empty;
        public bool HasValidName()
        {
            // Check if Name is not null using pattern matching
            if (this is { Name: not null })
            {
                return true;
            }
            return false;
        }
    }
}
