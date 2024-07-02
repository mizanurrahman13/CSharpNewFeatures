using LC1678_GoalParserInterpretation;

Solution solution = new Solution();

//string command = "G()(al)";
string command = "(al)G(al)()()G";

Console.WriteLine(solution.Interpret(command));
