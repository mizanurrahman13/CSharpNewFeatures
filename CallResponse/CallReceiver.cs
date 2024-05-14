public abstract class CallReceiver
{
    public string Name { get; set; }

    public CallReceiver(string name)
    {
        Name = name;
    }

    public abstract void ReceiveCall();

    public virtual void ForwardCall(CallReceiver nextReceiver)
    {
        Console.WriteLine($"{Name} forwarding the call to {nextReceiver.Name}");
        nextReceiver.ReceiveCall();
    }
}
