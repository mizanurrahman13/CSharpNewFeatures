

namespace CSharp13;

public class LockResourceAccess
{
    private readonly Lock _lock;

    public LockResourceAccess(Lock lockInstance)
    {
        _lock = lockInstance;
    }

    public void AccessResource(string name)
    {
        using (_lock.EnterScope())
        {
            Console.WriteLine($"{name} has entered the critical section.");
            Thread.Sleep(2000);
            Console.WriteLine($"{name} is leaving the critical section.");
        }
    }
}
