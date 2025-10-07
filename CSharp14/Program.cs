using CSharp14;

var data = new ImplicitSpanConversion();

int[] numbers = { 1, 2, 3, 4, 5 };
data.ProcessData(numbers); // Implicit conversion from int[] to ReadOnlySpan<int>

//Parameter Modifiers in Lambda Expressions
var lambda = new LambdaExpressions();

Console.WriteLine("Enter a number:");
string input = Console.ReadLine();

if (lambda.parse(input, out int number))
{
    Console.WriteLine($"Parsed successfully: {number}");
}
else
{
    Console.WriteLine("Failed to parse input as an integer.");
}


//nameof with Unbound Generics
Console.WriteLine(nameof(List<>)); // Output: List

//Null conditional assignment
var customer = new Customer { Name = "Muhammad" };
static Order GetCurrentOrder()
{
    return new Order
    {
        OrderId = Guid.NewGuid().ToString(),
        ProductName = "Ludo Star Club Membership",
        OrderDate = DateTime.Now,
        Amount = 499.99m
    };
}

//berfore C# 14
if (customer is not null)
{
    customer.Order = GetCurrentOrder();
}

//in C# 14
Console.WriteLine(customer?.Order = GetCurrentOrder());