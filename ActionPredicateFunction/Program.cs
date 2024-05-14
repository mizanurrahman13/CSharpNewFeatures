Action<int, int> add = (a, b) => 
    Console.WriteLine(a + b);
add(4, 5);

Predicate<string> isLong = s =>
    s.Length > 5;
bool result = isLong("Hello");
Console.WriteLine(result);

Func<int, int, int> multiply = (a, b) =>
    a * b;
int product = multiply(4, 5);
Console.WriteLine(product);