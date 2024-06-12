namespace LSP;

/*
 LSP says :- 
- Derived class must be correctly substitutable for base class
- Subtypes must be substitutable for their base type (interface, class)
- Sub class should be able to replace objects of base class without affecting

LSP tell us how to use inheritance properly , if you see somewhere in your code NotImplementedException
then it is most probably violation of LSP.

Benefits of LSP:- 
- Code reusability
- More maintainable code
- Better use of inheritance

Example
Bad:- A base class with some methods and sub classes throwing NotImplementedException for those methods it don't need

Good:- A base class with some methods and sub classes implement those methods and those are needed as well.

 */

public abstract class Vehicle
{
    public abstract void Drive();
}

public class Car : Vehicle
{
    public override void Drive() =>
        Console.WriteLine("I'm driving a Car");
}

public class Jeep : Vehicle
{
    public override void Drive() =>
        Console.WriteLine("I'm driving a Jeep");
}