
#region Raw String Literals
string longMessage = """
    This is a long message.
    It has several lines.
        Some are indented
            more than others.
    Some should start at the first column.
    Some have "quoted text" in them.
    """;
Console.WriteLine(longMessage);
#endregion

#region List Patterns
int[] numbers = { 1, 2, 3 };
Console.WriteLine(numbers is [1, 2, 3]); // True
Console.WriteLine(numbers is [1, 2, 4]); // False
Console.WriteLine(numbers is [1, 2, 3, 4]); // False
Console.WriteLine(numbers is [0 or 1, <= 2, >= 3]); // True

List<int> numbers2 = new() { 1, 2, 3 };

if (numbers2 is [var first, _, _])
{
    Console.WriteLine($"The first element of a three-item list is {first}.");
}
#endregion

#region File-Scoped Types
file class FileScopedHelper
{
    public void PrintMessage()
    {
        Console.WriteLine("This class is file-scoped!");
    }
}

public class PublicClass
{
    public void UseHelper()
    {
        var helper = new FileScopedHelper();
        helper.PrintMessage();
    }
}

#endregion
#region Required Members

//WRONG:
//var invalidProduct = new Product();

//ERROR: Required member 'Product.Name' must be set
//in the object initializer or attribute constructor.
//ERROR: Required member 'Product.Price' must be set
//in the object initializer or attribute constructor.

// CORRECT: All required members are initialized
//var product = new Product
//{
//    Name = "Laptop",
//    Price = 999.99m
//};

//Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
#endregion
