namespace LC155_MinStack;

public class MinStack
{
    Stack<int> stack = null;
    Stack<int> minStack = null;
    public MinStack()
    {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }

    public void Push(int val)
    {
        if (minStack.Count > 0)
        {
            int minValue = minStack.Peek();
            if (minValue >= val)
                minStack.Push(val);
        }
        else
            minStack.Push(val);

        stack.Push(val);
    }

    public void Pop()
    {
        int value = 0;
        value = stack.Pop();

        if (minStack.Count > 0 && value == minStack.Peek())
            minStack.Pop();
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return minStack.Peek();
    }
}
