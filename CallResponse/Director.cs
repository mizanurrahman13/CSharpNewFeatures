public class Director : CallReceiver
{
    public Director(string name) : base(name)
    {
    }

    public override void ReceiveCall()
    {
        Console.WriteLine($"{Name} is receiving the call");
    }
}
