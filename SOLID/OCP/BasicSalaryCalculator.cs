namespace OCP;

/*
 * 
Open/Close Principle says :- 
1) Classes/methods/modules should open for extension but closed for modification

2) New functionality should be implemented by adding new class and methods instead of changing the existing class and its methods

What if I don't follow OCP :- 
- We break SRP
- Effects other part of code
- Difficult to maintain code
- More testing , more headache
- Costly in time/cost and resource.

Multiple ways to implement OCP :- 
- Using abstract class
- Using interfaces

Example 
Bad :- A single method of class responsible for calculating basic salary , when new requirement comes we add a new if condition and solve it

Good :- A base abstract class with abstract method and children class override it according their needs

 */

public class BasicSalaryCalculator
{
    public decimal GetBasicSalary(EmployeeType employeeType)
    {
        decimal basicSalary = 0;
        if (employeeType == employeeType.Contract)
        {

        }
        // new requirment
        else if (employeeType == employeeType.Parmanent)
        {

        }

        return basicSalary;
    }
}

public abstract class BasicSalary
{
    public abstract double GetBasicSalary(EmployeeType employeeType);
}

public class PermanentEmployeeBasicSalary : BasicSalary
{
    public override double GetBasicSalary(EmployeeType employeeType)
    {
        double calculateSalary=1000;

        return calculateSalary;
    }
}

public class ContractEmployeeBasicSalary : BasicSalary
{
    public override double GetBasicSalary(EmployeeType employeeType)
    {
        double calculateSalary = 1000;

        return calculateSalary;
    }
}

public class EmployeeType
{
    public EmployeeType Contract { get; internal set; }
    public EmployeeType Parmanent { get; internal set; }
}