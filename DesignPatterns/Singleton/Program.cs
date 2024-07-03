using Singleton;

PresidentOffice president1 = PresidentOffice.GetInstance();
PresidentOffice president2 = PresidentOffice.GetInstance();

bool areSameInstance = (president1 == president2);

Console.WriteLine($"Are the two instances the same? {areSameInstance}");

president1.MakeImportantDecision("Declare national holiday on July 28th!");
president2.MakeImportantDecision("Increase funding for education");
/*
 * We attempted to create two instances of the President's Office. However, the GetInstance() method ensured that both
 * instances point to the same memory address, demondtrating that the instance across the entire application.
 */

/*
 * Use Cases =>
 * 1. Global Configuration Settings.
 * 2. Logging.
 * 3. Caching Mechanisms.
 * 4. Application State Management.
 */
