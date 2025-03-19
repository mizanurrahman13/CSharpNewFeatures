using System;
using Csharp12;
using System.Collections.Immutable;
using System.Reflection;

var mizan = new Person("Mizanur", "Rahman");

Console.WriteLine($"{mizan.FirstName}, {mizan.LastName}");


ReportFields(mizan);
ReportFields(new Department1("C#", new("Rifat", "Chowdhury")));
ReportFields(new Department2("C#", new("Rifat", "Chowdhury")));

ReportFields(new Department3("C#", new("Rifat", "Chowdhury")));
ReportFields(new CorporateServices(Comparer<Person>.Default));



void ReportFields<T>(T obj) =>
    Console.WriteLine($"{typeof(T).Name.PadLeft(20)}: {string.Join(", ", GetFieldNames(obj))}");

IEnumerable<string> GetFieldNames<T>(T obj) =>
    typeof(T).GetFields(BindingFlags.NonPublic | BindingFlags.Instance).Select(x => x.Name);

//use primary constructor params only for state initialization else you will regrate for other uses
class CorporateServices(IComparer<Person> managerComparer)
{
    private readonly IComparer<Person> _managerComparer = managerComparer;

    public Person GetBestManager(Department2 first, params Department2[] others)
    {
        var best = first.Manager;

        foreach(var candidate in others.Select(department=> department.Manager))
        {
            if (_managerComparer.Compare(best, candidate) < 0) 
                best = candidate;
            //managerComparer = Comparer<Person>.Default;
        }

        return best;
    }
}

class Department4(string name, Person manager)
{
    public string Name { get; } = name;
    public Person Manager { get; } = manager;
    public IEnumerable<Person> Members => MembersImpl;

    private ImmutableList<Person> MembersImpl { get; } = ImmutableList<Person>.Empty;

    public Department4(string name, Person manager, IEnumerable<Person> members)
        : this(name, manager, ImmutableList<Person>.Empty.AddRange(members)){ }
    
    private Department4(string name, Person manager, ImmutableList<Person> members)
        : this(name, manager) =>
        MembersImpl = members;

    public Department4 Add(Person member, params Person[] others) =>
        new(Name, Manager, MembersImpl.Add(member).AddRange(others));
}

class Department3(string name, Person manager)
{
    public override string ToString() =>
        $"{name} dept. maneged by {manager.FirstName}";
}

class Department2(string name, Person manager)
{
    public string Name { get; } = name;
    public Person Manager { get; } = manager;
}

class Department1
{
    public string Name { get; }
    public Person Manager { get; }

    public Department1(string name, Person manager) =>
        (Name, Manager) = (name, manager);
}

record Person(string FirstName, string LastName);

#region Primary Constructure
//Employee employee = new Employee("John Doe", 30);
//employee.DisplayInfo(); // Output: Employee Name: John Doe, Age: 30
#endregion

#region Collection Expressions
// Create an array:
int[] a = [1, 2, 3, 4, 5, 6, 7, 8];

// Create a list:
List<string> b = ["one", "two", "three"];
#endregion

#region Inline Collections with Ranges and Slices
// Inline collection creation
int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

// Using ranges to get a subset
var middleNumbers = numbers[3..7]; // Gets elements at index 3, 4, 5, and 6

Console.WriteLine("Middle Numbers:");
foreach (var number in middleNumbers)
{
    Console.WriteLine(number);
}

var firstThree = numbers[..3]; // Gets the first 3 elements

Console.WriteLine("\nFirst Three Numbers:");
foreach (var number in firstThree)
{
    Console.WriteLine(number);
}

var lastThree = numbers[^3..]; // Gets the last 3 elements

Console.WriteLine("\nLast Three Numbers:");
foreach (var number in lastThree)
{
    Console.WriteLine(number);
}
#endregion

#region Default values for lambda expressions
// Lambda with default parameter value
var add = (int x = 10, int y = 5) => x + y;

// Using default values
Console.WriteLine(add());       // Output: 15 (10 + 5)

// Overriding default values
Console.WriteLine(add(20, 30)); // Output: 50 (20 + 30)
Console.WriteLine(add(7));      // Output: 12 (7 + 5)
#endregion
