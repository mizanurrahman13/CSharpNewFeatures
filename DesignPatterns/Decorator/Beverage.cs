/*
 * Do you love coffee? With what flavors?

Let's create it with a Decorator pattern ☕ 

The Decorator Pattern is a structural design pattern that allows you to add new functionalities
to an existing object without altering its structure. 

It involves a set of decorator classes that are used to wrap concrete components. 

For example: making a coffee. 

At its core, you might have a simple beverage like "Just a coffee" (my way).
However, you can also have variations like a coffee with milk, a coffee with whipped cream,
a coffee with chocolate, etc. 

Instead of creating distinct subclasses for each combination, you can use the Decorator Pattern
to "decorate" your coffee with add-ons. 👇 

When to use the Decorator pattern?

• Large Number of Features: 
Instead of having a separate subclass for each combination, you can "mix and match" with decorators. 
 
• Single Responsibility﻿ Principle: 
It allows you to divide a class that has several responsibilities into several smaller classes.

• To Avoid Modification: 
If you have an existing class, and you want to add new functionalities without modifying it, then the decorator is a good choice.

• Replacing Multiple Inheritance: 
C# doesn't support multiple inheritance. If you're trying to add functionalities from several sources to a single class, then using a decorator might be a good alternative.

 */

namespace Decorator;
public abstract class Beverage
{
    public abstract string Description();
    public abstract double Cost();
}

public class Coffee : Beverage
{
    public override string Description()
    {
        return "Coffee";
    }

    public override double Cost()
    {
        return 1.0;
    }
}

public abstract class BeverageDecorator : Beverage
{
    protected Beverage beverage;

    public BeverageDecorator(Beverage beverage)
    {
        this.beverage = beverage;
    }
}

public class MilkDecorator : BeverageDecorator
{
    public MilkDecorator(Beverage beverage) 
        : base(beverage) { }

    public override string Description()
    {
        return beverage.Description() + ", Milk";
    }

    public override double Cost()
    {
        return beverage.Cost() + 0.2;
    }
}

public class WhippedCreamDecorator : BeverageDecorator
{
    public WhippedCreamDecorator(Beverage beverage)
        : base(beverage) { }

    public override string Description()
    {
        return beverage.Description() + ", Whipped Cream";
    }

    public override double Cost()
    {
        return beverage.Cost() + 0.5;
    }
}

