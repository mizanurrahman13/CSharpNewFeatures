using LC155_MinStack;

MinStack minStack = new MinStack();

minStack.Push(-2);
minStack.Push(0);
minStack.Push(-3);
minStack.GetMin(); // return -3
minStack.Pop();
minStack.Top();    // return 0
minStack.GetMin(); // return -2

Console.WriteLine(minStack.GetMin());
Console.WriteLine(minStack.Top());
Console.WriteLine(minStack.GetMin());
