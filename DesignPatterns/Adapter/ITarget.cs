/*
 * Adapter Design Pattern - Simplifed💡

Definition:

The adapter pattern converts the interface of a class into another interface clients expect. 
The adapter lets classes work together that couldn’t otherwise because of incompatible interfaces.

Real-Wolrd Analogy:

• Stefan from Serbia arrived in the UK.
• Stefan has a classic EU charger with a two-part outlet.
• The UK has a standard three-part plug.

How will Stefan charge his phone?

Answer: By using an adapter.

The adapter creates the possibility of connecting two different interfaces 
(2 plugs). 
It gets one type of input and produces a different type of output.

When to use:

• Ado .Net SqlAdapter, MySqlAdapter
• Allow a system to use classes of another system that is incompatible with it.

 */

namespace Adapter;
public interface ITarget
{
    string GetRequest();
}

public class Adaptee
{
    public string GetSpecificRequest()
    {
        return "Specific request";
    }
}

public class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        this._adaptee = adaptee;
    }

    public string GetRequest()
    {
        return $"This is '{this._adaptee.GetSpecificRequest()}'";
    }
}


