using ChainResponsibility;

List<Person> scientists = new()
{
    new("Isaac", "Newton", new(1643, 1, 4)),
    new("Albert", "Einstein", new(1879, 3, 14)),
    new("Marie", "Curie", new(1867, 11, 7)),
    new("Charles", "Darwin", new(1809, 2, 12)),
    new("Alan", "Turing", new(1912, 6, 23)),
    new("Nikola", "Tesla", new(1856, 7, 10)),
    new("Claude", "Shanoon", new(1916, 4, 30)),
    new("Ada", "Lovelace", new(1815, 12, 10))
};

IComparer<Person> ageComparer =
    Comparer<Person>.Create((a, b) => a.AgeToday.CompareTo(b.AgeToday));
IComparer<Person> lastNameComparer = Comparer<Person>.Create((a, b) =>
    StringComparer.CurrentCultureIgnoreCase.Compare(a.LastName, b.LastName));
IComparer<Person> firstNameComparer = Comparer<Person>.Create((a, b) =>
    StringComparer.CurrentCultureIgnoreCase.Compare(a.FirstName, b.FirstName));
IComparer<Person> birthCenturyComparer = Comparer<Person>.Create((a, b) =>
    ((a.BirthDate.Year - 1) / 100).CompareTo((b.BirthDate.Year - 1)/ 100));

scientists.SortAndPrint(birthCenturyComparer
    .Then(firstNameComparer)
    .Then(lastNameComparer));
