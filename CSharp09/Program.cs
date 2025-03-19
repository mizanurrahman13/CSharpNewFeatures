using static CSharp09.InitOnlySetters;

var person = new Person { Name = "Nabila" };

if (person is not null && person.HasValidName())
{
    Console.WriteLine($"Person exists and has a valid name called {person.Name}");
}
else
{
    Console.WriteLine("Name is null or person object is null.");
}

List<Person> people = new();

people.Add(new Person { Name = "Lamia" });
people.Add(new Person { Name = "Zunayed" });

foreach (var p in people)
{
    Console.WriteLine(p.Name);
}
