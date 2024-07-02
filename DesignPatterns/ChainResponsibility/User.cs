namespace ChainResponsibility;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Password {  get; set; } = string.Empty;
    public DateTimeOffset DateOfBirth {  get; set; }
}