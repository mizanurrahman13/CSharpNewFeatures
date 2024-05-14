public class Employee : CallReceiver
{
    public Employee(string name) : base(name)
    {
    }

    public override void ReceiveCall()
    {
        Console.WriteLine($"{Name} is receiving the call");
    }
}