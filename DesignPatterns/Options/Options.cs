/*
 * Tired of managing application settings in .NET projects?

The Options Pattern is here to simplify things. 🚀

The Options Pattern provides a simple and flexible way to configure settings for your application. It is often used in conjunction with dependency injection to make it easier to manage and update application settings.

You can centralize your application's configuration settings in one place, making it easier to update and maintain your code. This is especially useful when you have multiple parts of your application that need to access the same settings.

Benefits:

• Simplifies application settings management
• Increases code maintainability
• Promotes code flexibility
• Enhances testability


 */

namespace Options;

//Step->1
public class Options
{
    public string ConnectionString { get; set; } = string.Empty;
    public int TimeOutSeconds { get; set; }
    public bool EnableLogging { get; set; }
}
