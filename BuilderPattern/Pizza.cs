namespace BuilderPattern;

public class Pizza
{
    public string Toppings { get; set; }
    public string CrustType { get; set; }
}

public class PizzaBuilder
{
    private Pizza _pizza = new Pizza();

    public PizzaBuilder AddToppings(string toppings)
    {
        _pizza.Toppings = toppings;
        return this;
    }

    public PizzaBuilder ChooseCrust(string crust)
    {
        _pizza.CrustType = crust;
        return this;
    }

    public Pizza Build()
    {
        return _pizza;
    }
}
