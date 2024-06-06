namespace LC2011_FinalValueofVariableAfterPerformingOperations;

public class Solution
{
    public int FinalValueAfterOperations(string[] operations)
    {
        int result = 0;
        foreach (var operation in operations)
        {
            if (operation == "--X" || operation == "X--")
                result--;
            if (operation == "++X" || operation == "X++")
                result++;
        }

        return result;
    }
}
