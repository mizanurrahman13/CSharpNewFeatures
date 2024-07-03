using Command;

Kitchen kitchen = new();
Waiter waiter = new();

waiter.TakeOrder(new MakePizzaCommand(kitchen));
waiter.TakeOrder(new MakePastaCommand(kitchen));

waiter.PlaceOrders();
