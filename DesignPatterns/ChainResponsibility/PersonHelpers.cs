namespace ChainResponsibility;
public static class PersonHelpers
{
    public static void SortAndPrint(this List<Person> people, IComparer<Person> sortOrder)
    {
        int firstNameLength = people.Select(p => p.FirstName.Length).DefaultIfEmpty(0).Max();
        int lastNameLength = people.Select(p => p.LastName.Length).DefaultIfEmpty(0).Max();

        people.Sort(sortOrder);

        foreach (Person person in people)
        {
            Console.WriteLine(
                $"{person.FirstName.PadRight(firstNameLength)} " +
                $"{person.LastName.PadRight(lastNameLength)} " +
                $"born in {person.BirthDate.Year}");
        }
        Console.WriteLine(new string('-', 40));
    }
}
