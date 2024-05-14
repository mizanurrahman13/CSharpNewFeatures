using VirtualandOverride;

ParmanentEmployee parmanentEmployee = new ParmanentEmployee();
parmanentEmployee.Name = "Lamia Ahmed";
parmanentEmployee.Email = "lamia@gmail.com";
parmanentEmployee.GrossSalary = 50000;
Console.WriteLine($"Salary for Full Time Employee: ${parmanentEmployee.CalculateSalary()} ", parmanentEmployee.CalculateSalary());

PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
partTimeEmployee.Name = "Nusrat Nabila";
partTimeEmployee.Email = "nabila@gmail.com";
partTimeEmployee.Hour = 50;
partTimeEmployee.Rate = 40M;
Console.WriteLine($"Salary for Part Time Employee: ${partTimeEmployee.CalculateSalary()} ", partTimeEmployee.CalculateSalary());
