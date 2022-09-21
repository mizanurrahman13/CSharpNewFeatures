using ConsoleUI;
using System;

// Top level calls
Console.WriteLine("Hello World!");

Console.WriteLine(Add(3, 4));

PersonModel person = new() { Id = 1, FirstName = "Lamia", LastName = "Ahmed" };
var person2 = new PersonModel { Id = 2, FirstName = "Nabila", LastName = "Nusrat" };
PersonModel person3 = new(3, "Sadia", "Islam"); 

//person.Id = 2;
Console.WriteLine($"Hello {person.FirstName} {person.LastName} ({person.Id})");

PersonModel person4 = null;

if (person4 is null)
    Console.WriteLine("The value of p4 is not set yet");
else
    Console.WriteLine($"Hello {person4.FirstName} {person4.LastName} ({person4.Id})");

if (person3 is not null)
    Console.WriteLine($"Hello {person3.FirstName} {person3.LastName} ({person3.Id})");

static double Add(double x, double y)
{
    return x + y;
}

