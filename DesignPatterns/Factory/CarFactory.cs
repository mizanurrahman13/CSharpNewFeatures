/*
What is the Factory Design pattern?

Explained. Simplified.

The Factory Design Pattern is a creational design pattern that provides an interface for creating objects without
specifying their concrete classes. It encapsulates the object creation logic in a separate class (the factory) 
and allows the client code to create objects through this factory interface. This pattern promotes loose coupling 
and enhances code flexibility by decoupling the client code from the actual object creation process.

Key components of the Factory Design Pattern:

1. Product (Car in our example): The interface or abstract class that represents the objects being created by the factory.
2. Concrete Products (BMW, Audi, Mercedes in our example): The specific implementations of the product interface.
3. Factory (CarFactory in our example): The class responsible for creating objects (concrete products) that implement 
the product interface. It abstracts the object creation process from the client code.

 */

namespace Factory;

public class CarFactory
{
    public Car CreateCar(string carType)
    {
        return carType.ToLower() switch
        {
            "bmw" => new BMW(),
            "audi" => new Audi(),
            "mercedes" => new Mercedes(),
            _ => throw new ArgumentException($"Invalid car type: {carType}"),
        };
    }
}

/*
 * When to use =>
 1. Object Creation is Complex: This simplifies the client code, as it only needs to call the factory method instead
        of dealing with the details of object creation.
 2. Dependency Management: If a class depends on concrete implementations, using the Factory Pattern allows you to
        inject the factory as a dependency.
 3. Loose Coupling: By using the Factory Pattern, the client code does not need to know the exact class of the objects
        it create
 4. Extensibility: You can simply create new concrete classes and update the factory, without modifying the client code.
 5. Unit Testing: Factories can b e easily mocked or replaced with stubs during unit testing, enabling isolated 
        testing of client code.
 */
