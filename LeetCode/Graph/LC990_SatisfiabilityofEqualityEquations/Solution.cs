namespace LC990_SatisfiabilityofEqualityEquations;

public class Solution
{
    private int[] parent = new int[26];

    // Find function with path compression
    private int Find(int x)
    {
        if (parent[x] != x)
            parent[x] = Find(parent[x]); // Path compression
        return parent[x];
    }

    // Union function
    private void Union(int x, int y)
    {
        parent[Find(x)] = Find(y);
    }

    public bool EquationsPossible(string[] equations)
    {
        // Initialize parent array
        for (int i = 0; i < 26; i++)
            parent[i] = i;

        // Process equality equations first
        foreach (var eq in equations)
        {
            if (eq[1] == '=')
                Union(eq[0] - 'a', eq[3] - 'a');
        }

        // Process inequality equations
        foreach (var eq in equations)
        {
            if (eq[1] == '!')
            {
                int x = Find(eq[0] - 'a');
                int y = Find(eq[3] - 'a');
                if (x == y) return false; // Conflict detected
            }
        }

        return true;
    }
}
