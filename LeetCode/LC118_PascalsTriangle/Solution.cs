namespace LC118_PascalsTriangle;

public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> list = new List<IList<int>>();
        for (int i = 0; i < numRows; i++)
        {
            IList<int> innerList = new List<int>();
            for (int j = 0; j <= i; j++)
            {
                if (i == 0 || j == 0 || j == i)
                    innerList.Add(1);
                else
                {
                    int sum = list[i - 1][j] + list[i - 1][j - 1];
                    innerList.Add(sum);
                }
            }
            list.Add(innerList);
        }

        return list;
    }
}
