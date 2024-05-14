public class Manager : CallReceiver
{
    public Manager(string name) : base(name)
    {
    }

    public override void ReceiveCall()
    {
        Console.WriteLine($"{Name} is receiving the call");
    }
}
