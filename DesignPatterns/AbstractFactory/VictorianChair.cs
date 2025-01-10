namespace AbstractFactory;

// Victorian Products
public class VictorianChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on a Victorian chair.");
    }
}

public class VictorianSofa : ISofa
{
    public void LieOn()
    {
        Console.WriteLine("Lying on a Victorian sofa.");
    }
}

// Modern Products
public class ModernChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on a Modern chair.");
    }
}

public class ModernSofa : ISofa
{
    public void LieOn()
    {
        Console.WriteLine("Lying on a Modern sofa.");
    }
}

