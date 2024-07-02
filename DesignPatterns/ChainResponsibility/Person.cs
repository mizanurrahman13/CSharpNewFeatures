namespace ChainResponsibility;
public record Person(string FirstName, string LastName, DateOnly BirthDate)
{
    public int AgeToday =>
        AgeOn(DateOnly.FromDateTime(DateTime.UtcNow.Date));

    public int AgeOn(DateOnly date) =>
        date.Year - BirthDate.Year - (IsPastBirthDayOn(date)?0:1);

    public bool IsPastBirthDayOn(DateOnly date) =>
        BirthDate.Month < date.Month ||
        BirthDate.Month == date.Month && BirthDate.Day < date.Day;
}
