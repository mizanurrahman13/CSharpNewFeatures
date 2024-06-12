namespace SRP;

/*
 * SRP says :- 
- A class/method should have one reason to change
- A class/method should have only one responsibility
- A class/method should be related to a single purpose

With SRP we achieve :- 
- Class/method becomes smaller and cleaner
- Now in future updating the code becomes easier

Example
Bad :- Single class responsible for Signup, Login , Logging Error and Sending the Email.

Good :- Different classes for different purpose 
 User Account related (Signup and Login) 
 Sending Email related (SendEmail)
 Logging related (LogInformation)

Now in future we can add LogError,LogWarning in our logging class and ForgotPasword in User Account.

Suppose if we had kept a single class and we add new methods in that class then its impact would have been everywhere 
where class has dependencies.

 */

//public class User
//{
//    public bool LogIn(string userName, string password)
//    {
//        return true;
//    }
//    public bool SignUp(UserDto user)
//    {
//        return true;
//    }

//    public bool SendEmail(SendEmailDto sendEmailDto)
//    {
//        return true;
//    }

//    public void LogInInformation(string message) { }
//}

public class User
{
    public bool LogIn(string userName, string password)
    {
        return true;
    }
    public bool SignUp(UserDto user)
    {
        return true;
    }
}

public class EmailService
{
    public bool SendEmail(SendEmailDto sendEmailDto)
    {
        return true;
    }

}

public class LoggingService
{
    public void LogInInformation(string message) { }
}

public class SendEmailDto { }

public class UserDto { }