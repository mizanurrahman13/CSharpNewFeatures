namespace Csharp12;

public class Employee(string name, int age)
{
    public string Name { get; } = name; // Automatically initialized
    public int Age { get; } = age;

    public void DisplayInfo()
    {
        Console.WriteLine($"Employee Name: {Name}, Age: {Age}");
    }
}
