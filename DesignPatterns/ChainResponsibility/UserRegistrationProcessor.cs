namespace ChainResponsibility;

public abstract class ValidationHandler
{
    protected ValidationHandler NextHandler;

    public ValidationHandler SetNext(ValidationHandler nextHandler)
    {
        NextHandler = nextHandler;
        return nextHandler;
    }

    public abstract void Handle(User user);
}

public class UsernameRequiredValidationHandler : ValidationHandler
{
    public override void Handle(User user)
    {
        if (string.IsNullOrWhiteSpace(user.Name))
            throw new Exception("UserName is required");

        NextHandler?.Handle(user);
    }
}

public class PasswordRequiredValidationHandler : ValidationHandler
{
    public override void Handle(User user)
    {
        if (string.IsNullOrWhiteSpace(user.Password))
            throw new Exception("Password is required");

        NextHandler?.Handle(user);
    }
}

public class OnlyAdultValidationHandler : ValidationHandler
{
    public override void Handle(User user)
    {
        if (user.DateOfBirth.Year > DateTime.Now.Year - 18)
            throw new Exception("Age under 18 is not allowed");
    }
}

public class UserRegistrationProcessor
{
    public void Register(User user)
    {
        if (string.IsNullOrWhiteSpace(user.Name))
            throw new Exception("UserName is required");
        if (string.IsNullOrWhiteSpace(user.Password))
            throw new Exception("Password is required");
        if (user.DateOfBirth.Year > DateTime.Now.Year - 18)
            throw new Exception("Age under 18 is not allowed");
    }
    public void Registers(User user)
    {
        var handler = new UsernameRequiredValidationHandler();
        handler.SetNext(new PasswordRequiredValidationHandler())
               .SetNext(new OnlyAdultValidationHandler());

        handler.Handle(user);
    }
}