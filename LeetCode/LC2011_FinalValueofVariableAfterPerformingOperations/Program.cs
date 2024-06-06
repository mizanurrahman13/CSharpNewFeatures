using LC2011_FinalValueofVariableAfterPerformingOperations;

Solution solution = new Solution();

string[] operations = new string[] { "X++", "++X", "--X", "X--" };

Console.WriteLine(solution.FinalValueAfterOperations(operations));
