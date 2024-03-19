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
