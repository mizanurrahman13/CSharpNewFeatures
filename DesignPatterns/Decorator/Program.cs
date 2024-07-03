using Decorator;

Beverage beverage = new Coffee();
Console.WriteLine($"{beverage.Description()}");

beverage = new MilkDecorator(beverage);
Console.WriteLine($"{beverage.Description()}");

beverage = new WhippedCreamDecorator(beverage);
Console.WriteLine($"{beverage.Description()}");

Console.ReadLine();
