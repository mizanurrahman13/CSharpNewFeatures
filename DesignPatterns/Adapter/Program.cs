using Adapter;

Adaptee adaptee = new Adaptee();
ITarget target = new Adapter.Adapter(adaptee);

Console.WriteLine(target.GetRequest());
