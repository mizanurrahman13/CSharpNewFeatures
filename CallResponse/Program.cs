Manager manager = new Manager("John");
Director director = new Director("Alice");
Employee employee = new Employee("Bob");

// Simulating a call
CallReceiver caller = manager; // Call comes to the manager first
caller.ReceiveCall();

// Manager forwards the call to director if not available
if (caller is Manager && !IsAvailable(manager))
{
    caller.ForwardCall(director);
}

// Simulating call from employee
caller = employee;
caller.ReceiveCall();

// Employee forwarding the call to manager if not available
if (caller is Employee && !IsAvailable(employee))
{
    caller.ForwardCall(manager);
}


static bool IsAvailable(CallReceiver receiver)
{
    // Simulating availability based on some logic
    return receiver.Name != "John"; // Manager John is not available
}
