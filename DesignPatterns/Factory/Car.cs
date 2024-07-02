namespace Factory;
public abstract class Car
{
    public abstract void Assemble();
}

public class BMW : Car
{
    public override void Assemble()
    {
        Console.WriteLine("Assembling BMW Car.");
    }
}

public class Audi : Car
{
    public override void Assemble()
    {
        Console.WriteLine("Assembling Audi Car.");
    }
}

public class Mercedes : Car
{
    public override void Assemble()
    {
        Console.WriteLine("Assembing Mercedes Car.");
    }
}
