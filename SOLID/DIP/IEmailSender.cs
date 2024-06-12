namespace DIP;

/*
 * it says, "High level module should not depend on low level module , instead both should depend on abstractions"

Benefits 
- Decoupling
- Testability
- Reusability

Multiple ways to implement DIP
- Constructor injection
- Property injection
- Method injection

Example 
Bad : Instead of using abstraction one using direct instantiation using new keyword everywhere.

Good : Relying on abstraction , registering dependency and using it via constructor injection (Method and Property injection as well)

We can achieve dependency injection using default DI container of .NET but we have some third party DI Container as well
- Autofac
- Ninject
- Castle Windsor

 */
public interface IEmailSender
{
    void Send(string emailAddress, string message);
}

public class EmailSender : IEmailSender
{
    public void Send(string emailAddress, string message) { }
}

public class NotificationService
{
    private IEmailSender _emailSender;

    public NotificationService(IEmailSender emailSender)
    {
        _emailSender = emailSender;
    }

    public void SendEmail(string  emailAddress, string message)
    {
        _emailSender.Send(emailAddress, message);
    }
}
