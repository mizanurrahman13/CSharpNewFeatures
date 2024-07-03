/*
 * Bring me a pizza, please 🍕 

This is a Command Pattern. Let's simplify it. 🚀 

The Command design pattern is a behavioral design pattern that turns a request into a stand-alone
object that contains information about the request. 

In a restaurant, a customer gives an order for a particular dish to a waiter. 
The waiter then passes the order to the kitchen staff, where the dish gets prepared.

𝐀𝐧𝐚𝐥𝐨𝐠𝐲:

• Customer = Client (main method for example)
• Order = Command 
• Waiter = Invoker
• Kitchen staff - Receiver 

By organizing the code this way, several advantages are gained:

1. The waiter (Invoker) does not need to know how to prepare the dish.
2. New dishes (Concrete Commands) can be added without changing the kitchen (Receiver) or the waiter (Invoker).
3. The customer (Client) only needs to specify what they want, not how to prepare it.

This separation of concerns makes the system more modular, easier to manage, and easier to extend.

𝐖𝐡𝐞𝐧 𝐭𝐨 𝐮𝐬𝐞 𝐢𝐭?

• 𝐃𝐞𝐜𝐨𝐮𝐩𝐥𝐢𝐧𝐠: 
When you want to decouple the sender and receiver of a request.

• 𝐏𝐚𝐫𝐚𝐦𝐞𝐭𝐞𝐫𝐢𝐳𝐚𝐭𝐢𝐨𝐧: 
When you need to parameterize objects with operations.

• 𝐐𝐮𝐞𝐮𝐞𝐢𝐧𝐠: 
When you want to queue requests for execution at different times.

• 𝐋𝐨𝐠𝐠𝐢𝐧𝐠 𝐚𝐧𝐝 𝐂𝐚𝐜𝐡𝐢𝐧𝐠: 
When you need to keep a history of requests or implement "undo" functionality.

• 𝐂𝐨𝐦𝐩𝐨𝐬𝐢𝐭𝐞 𝐂𝐨𝐦𝐦𝐚𝐧𝐝𝐬: 
To compose simple commands into complex ones.

 */

namespace Command;

//Command
public interface IOrderCommand
{
    void Execute();
}

public class MakePizzaCommand : IOrderCommand
{
    private Kitchen kitchen;

    public MakePizzaCommand(Kitchen kitchen) =>
        this.kitchen = kitchen;

    public void Execute() =>
        kitchen.PreparePizza();
}

public class MakePastaCommand : IOrderCommand
{
    private Kitchen kitchen;

    public MakePastaCommand(Kitchen kitchen) =>
        this.kitchen = kitchen;

    public void Execute() =>
        kitchen.PreparePasta();
}

//Receiver
public class Kitchen
{
    public void PreparePizza() =>
        Console.WriteLine("Preparing Pizza!");

    public void PreparePasta() =>
        Console.WriteLine("Preparing Pasta!");
}

//Invoker
public class Waiter
{
    private List<IOrderCommand> orders = new();

    public void TakeOrder(IOrderCommand order) =>
        orders.Add(order);

    public void PlaceOrders()
    {
        foreach (var order in orders)
            order.Execute();

        orders.Clear();
    }
}
