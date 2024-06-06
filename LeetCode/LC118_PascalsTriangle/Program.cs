using LC118_PascalsTriangle;

Solution solution = new Solution();
IList<IList<int>> list = new List<IList<int>>();
int numRows = 10;
list = solution.Generate(numRows);

for (int i = 0; i < list.Count; i++)
{
    Console.Write("Row " + i + ": ");
    for (int j = 0; j < list[i].Count; j++)
    {
        Console.Write(list[i][j] + " ");
    }
    Console.WriteLine();
}
