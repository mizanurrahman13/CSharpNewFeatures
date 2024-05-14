namespace VirtualandOverride;

public class ParmanentEmployee : Employee
{
    public string Name { get; set; }
    public string Email { get; set; }
    public decimal GrossSalary { get; set; }

    public override decimal CalculateSalary()
    {
        return GrossSalary;
    }
}
