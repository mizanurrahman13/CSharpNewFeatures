namespace VirtualandOverride;

public abstract class Employee
{
    public string Name { get; set; }
    public string Email { get; set; }
    public decimal GrossSalary { get; set; }

    public virtual decimal CalculateSalary()
    {
        return GrossSalary;
    }
}
