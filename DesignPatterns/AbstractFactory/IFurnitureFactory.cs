namespace AbstractFactory;

// Abstract Factory
public interface IFurnitureFactory
{
    IChair CreateChair();
    ISofa CreateSofa();
}

