using System.Collections;
using System.Linq;

namespace LC957_PrisonCellsAfterNDays;

public class Solution
{
    public int[] PrisonAfterNDays(int[] cells, int n)
    {
        if (cells == null || cells.Length == 0 || n <= 0)
            return cells;

        bool hasCycle = false;
        int cycle = 0;
        HashSet<string> set = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            int[] next = nextDay(cells);
            var key = next.ToString();
            if (!set.Contains(key))
            {
                set.Add(key);
                cycle++;
            }
            else
            {
                hasCycle = true;
                break;
            }
            cells = next;
            
        }
        if (hasCycle)
        {
            n %= cycle;
            for (int i = 0; i < n; i++) 
            {
                cells = nextDay(cells);
            }
        }

        return cells;
    }

    private int[] nextDay(int[] cells)
    {
        int[] temp = new int[cells.Length];

        for (int i = 1; i < cells.Length - 1; i++)
        {
            temp[i] = cells[i - 1] == cells[i + 1] ? 1 : 0;
        }

        return temp;
    }
}
