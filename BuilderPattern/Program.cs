using BuilderPattern;

Pizza customPizza = new PizzaBuilder()
    .AddToppings("Pepperoni, Mushrooms, Olives")
    .ChooseCrust("Thin Crust")
    .Build();

Console.WriteLine("Custom Pizza:");
Console.WriteLine($"Toppings: {customPizza.Toppings}");
Console.WriteLine($"Crust: {customPizza.CrustType}");
