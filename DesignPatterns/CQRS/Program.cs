/*
 * What is CQRS? Simplified. 💡 

Let's go to the kitchen, again. 😅 

"𝐇𝐢, 𝐒𝐭𝐞𝐟𝐚𝐧. 𝐈 𝐤𝐞𝐞𝐩 𝐬𝐞𝐞𝐢𝐧𝐠 𝐩𝐨𝐬𝐭𝐬 𝐚𝐛𝐨𝐮𝐭 𝐂𝐐𝐑𝐒, 𝐛𝐮𝐭 𝐜𝐚𝐧 𝐲𝐨𝐮 𝐞𝐱𝐩𝐥𝐚𝐢𝐧 𝐢𝐧 𝐲𝐨𝐮𝐫 𝐰𝐚𝐲, 𝐢𝐧 𝐚 𝐬𝐢𝐦𝐩𝐥𝐢𝐟𝐢𝐞𝐝 𝐰𝐚𝐲, 𝐡𝐨𝐰 𝐢𝐭 𝐰𝐨𝐫𝐤𝐬?" - Sure.

So, CQRS stands for 𝐂𝐨𝐦𝐦𝐚𝐧𝐝 𝐐𝐮𝐞𝐫𝐲 𝐑𝐞𝐬𝐩𝐨𝐧𝐬𝐢𝐛𝐢𝐥𝐢𝐭𝐲 𝐒𝐞𝐠𝐫𝐞𝐠𝐚𝐭𝐢𝐨𝐧.
CQRS is an architectural pattern that separates the concerns of reading data from the concerns of updating data,
by having different objects handle reading and updating data.

In .NET, we can implement CQRS using the 𝐌𝐞𝐝𝐢𝐚𝐭𝐑 𝐥𝐢𝐛𝐫𝐚𝐫𝐲, which provides a simple way to handle commands
and queries in a decoupled way.

MediatR defines two main classes: 𝐈𝐑𝐞𝐪𝐮𝐞𝐬𝐭 and 𝐈𝐑𝐞𝐪𝐮𝐞𝐬𝐭𝐇𝐚𝐧𝐝𝐥𝐞𝐫. 
• A class that implements IRequest represents the command.
• A class that implements IRequestHandler represents the query.

The MediatR library includes a mediator class that can be used to send commands and queries to the appropriate handlers.

Great. Okay, let's make it more clear.

𝐓𝐡𝐞 𝐚𝐧𝐚𝐥𝐨𝐠𝐲 𝐟𝐨𝐫 𝐂𝐐𝐑𝐒 𝐜𝐨𝐮𝐥𝐝 𝐛𝐞 𝐚 𝐜𝐡𝐞𝐟 𝐢𝐧 𝐚 𝐤𝐢𝐭𝐜𝐡𝐞𝐧. 
The chef is responsible for executing commands (cooking orders) and querying the kitchen state 
(checking if ingredients are available).

The chef would have 𝐚 𝐬𝐞𝐩𝐚𝐫𝐚𝐭𝐞 𝐬𝐞𝐭 𝐨𝐟 𝐭𝐨𝐨𝐥𝐬 for:
• executing commands (a stove, oven)
• querying the kitchen state (a fridge, pantry).

The chef would have 𝐝𝐢𝐟𝐟𝐞𝐫𝐞𝐧𝐭 𝐬𝐤𝐢𝐥𝐥𝐬 𝐚𝐧𝐝 𝐤𝐧𝐨𝐰𝐥𝐞𝐝𝐠𝐞 for:
• executing commands (cooking techniques)
• querying the kitchen state (inventory management).

The chef would use 𝐝𝐢𝐟𝐟𝐞𝐫𝐞𝐧𝐭 𝐩𝐫𝐨𝐜𝐞𝐬𝐬𝐞𝐬 for:
• executing commands ( following a recipe)
• querying the state of the kitchen (checking inventory levels).

By separating the concerns of reading and updating data, the chef's work is more organized, manageable,
and less prone to errors.
And the same applies to software systems that use CQRS, which makes the code more organized, 
and less prone to errors.

 */
using MediatR;

// Define the command (represents cooking orders)
public class CookOrderCommand : IRequest
{
    public string DishName { get; set; }
}

// Define the query (represents checking ingredient availability)
public class CheckIngredientAvailabilityQuery : IRequest<bool>
{
    public string IngredientName { get; set; }
}

// Define the command handler
public class CookOrderCommandHandler : IRequestHandler<CookOrderCommand>
{
    public Task<Unit> Handle(CookOrderCommand request, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Cooking order: {request.DishName}");
        // Logic to cook the order goes here
        return Task.FromResult(Unit.Value);
    }

    Task IRequestHandler<CookOrderCommand>.Handle(CookOrderCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

// Define the query handler
public class CheckIngredientAvailabilityQueryHandler : IRequestHandler<CheckIngredientAvailabilityQuery, bool>
{
    public Task<bool> Handle(CheckIngredientAvailabilityQuery request, CancellationToken cancellationToken)
    {
        // Simulate checking ingredient availability (always available for this example)
        return Task.FromResult(true);
    }
}

//class Program
//{
//    static async Task Main()
//    {
//        var mediator = new Mediator(cfg =>
//        {
//            cfg.AddMediatR(typeof(Program).Assembly);
//        });

//        // Example usage
//        var orderCommand = new CookOrderCommand { DishName = "Pasta" };
//        await mediator.Send(orderCommand);

//        var ingredientQuery = new CheckIngredientAvailabilityQuery { IngredientName = "Tomato" };
//        var isAvailable = await mediator.Send(ingredientQuery);

//        Console.WriteLine($"Ingredient availability: {isAvailable}");
//    }
//}

