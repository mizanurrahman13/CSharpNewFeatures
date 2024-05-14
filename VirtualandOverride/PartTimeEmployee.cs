namespace VirtualandOverride;

public class PartTimeEmployee : Employee
{
    public string Name { get; set; }
    public string Email { get; set; }
    public decimal Hour { get; set; }
    public decimal Rate { get; set; }

    public override decimal CalculateSalary()
    {
        return Hour * Rate;
    }
}
