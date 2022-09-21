using System;
using System.Collections.Generic;
/**
* Benefits of Records:
* - Simple to set up
* - Thread-safe
* - Easy/safe to share
* 
* When to Use Records:
* - Capturing external data that doesn't change - WeatherService, SWAPI.dev
* - API calls
* - Processing data
* - Read-Only data
* 
* When not to Use Records:
* - when you need to change the data (Entity Framework)
* 
**/

namespace RecordDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Record1 r1a = new("Lamia", "Ahmed");
            Record1 r1b = new("Lamia", "Ahmed");
            Record1 r1c = new("Sadia", "Islam");

            Class1 c1a = new("Lamia", "Ahmed");
            Class1 c1b = new("Lamia", "Ahmed");
            Class1 c1c = new("Sadia", "Islam");

            Console.WriteLine("Record Type:");
            Console.WriteLine($"To String: {r1a}");
            Console.WriteLine($"Are the two objects equal: {Equals(r1a, r1b)}");
            Console.WriteLine($"Are the two objects reference equal: {ReferenceEquals(r1a, r1b)}");
            Console.WriteLine($"Are the two objects ==: {r1a == r1b}");
            Console.WriteLine($"Are the two objects !=: {r1a != r1c}");
            Console.WriteLine($"Hash code of object A: {r1a.GetHashCode()}");
            Console.WriteLine($"Hash code of object B: {r1b.GetHashCode()}");
            Console.WriteLine($"Hash code of object C: {r1c.GetHashCode()}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            Console.WriteLine("Class Type:");
            Console.WriteLine($"To String: {c1a}");
            Console.WriteLine($"Are the two objects equal: {Equals(c1a, c1b)}");
            Console.WriteLine($"Are the two objects reference equal: {ReferenceEquals(c1a, c1b)}");
            Console.WriteLine($"Are the two objects ==: {c1a == c1b}");
            Console.WriteLine($"Are the two objects !=: {c1a != c1b}");
            Console.WriteLine($"Hash code of object A: {c1a.GetHashCode()}");
            Console.WriteLine($"Hash code of object B: {c1b.GetHashCode()}");
            Console.WriteLine($"Hash code of object C: {c1c.GetHashCode()}");

            Console.WriteLine();

            var (fn, ln) = r1a;
            Console.WriteLine($"The value of fn is {fn} and the value of ln is {ln}");

            Record1 r1d = r1a with
            {
                FirstName = "Mizan"
            };
            Console.WriteLine($"Mizan's record: {r1d}");

            Console.WriteLine();

            Record2 r2a = new("Lamia", "Ahmed");
            Console.WriteLine($"R2a value:{r2a}");
            Console.WriteLine($"R2a fn: {r2a.FirstName}  ln: {r2a.LastName}");
            Console.WriteLine(r2a.SayHi());
        }
    }

    // A Record is just a fancy class
    // Immutable - The values cannot be changes
    public record Record1 (string FirstName, string LastName);
    public record User1(int Id, string FirstName, string LastName) : Record1(FirstName, LastName);

    public class DiscoveryModel
    {
        public User1 LookupUser { get; set; }
        public int IncidentsFound { get; set; }
        public List<string> Incidents { get; set; }
    }

    public record Record2 (string FirstName, string LastName)
    {
        private string _firstName = FirstName;
        public string FirstName 
        { 
            get { return _firstName.Substring(0, 1); }
            init { }
        }
        public string FullName { get => $"{FirstName} {LastName}"; }

        public string SayHi()
        {
            return $"Hi {FirstName}";
        }
    }

    public class Class1
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public Class1(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Deconstruct(out string FirstName, out string LastName)
        {
            FirstName = this.FirstName;
            LastName = this.LastName;
        }

        //***************************
        // DO NOT DO ANY OF THE BELOW
        //***************************
        public record Record3 // No constructor so no deconstructor
        {
            public string FirstName { get; set; } // The set makes this record mutable (BAD!)
            public string LastName { get; set; } // The set makes this record mutable (BAD!)
        }

        // Don't just make clones all over to update state
    }
}
