/*
 * Credit goes to <<<Stefan Đokić>>>
 * What is the most simple design pattern? 

Singleton, of course. 😁 

However, I know there are people who don't know it and don't understand it. Let's create a quick explanation. 

The Singleton pattern is a creational design pattern that ensures a class has only one instance 
and provides a global access point to that instance throughout the entire application's runtime. 

This pattern guarantees that no matter how many times the Singleton class is instantiated,
there will be only one unique instance of that class, and all subsequent calls to obtain the 
instance will return a reference to the same object.

The example and source code you can check below. 

The Singleton pattern is commonly used when you want to control access to a shared resource
or centralize certain functionalities to maintain consistency and avoid conflicts.
However, it should be used judiciously and only when a single instance is genuinely required
throughout the application's lifetime. 

 */

namespace Singleton;
public class PresidentOffice
{
    private static PresidentOffice _instance;

    protected PresidentOffice() { }

    public static PresidentOffice GetInstance()
    {
        if ( _instance == null )
            _instance = new PresidentOffice();

        return _instance;
    }

    public void MakeImportantDecision(string decision)
    {
        Console.WriteLine(decision);
    }
}
