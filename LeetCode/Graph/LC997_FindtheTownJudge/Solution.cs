namespace LC997_FindtheTownJudge;

public class Solution
{
    public int FindJudge(int n, int[][] trust)
    {
        // Build adjacency list: who trusts whom
        var graph = new Dictionary<int, List<int>>();
        for (int i = 1; i <= n; i++)
            graph[i] = new List<int>();

        foreach (var pair in trust)
            graph[pair[0]].Add(pair[1]);

        // Candidate must trust no one
        int candidate = -1;
        for (int i = 1; i <= n; i++)
        {
            if (graph[i].Count == 0)
            {
                candidate = i;
                break;
            }
        }

        if (candidate == -1) return -1;

        // Check if everyone else can reach the candidate
        int count = 0;
        foreach (var kvp in graph)
        {
            int person = kvp.Key;
            if (person == candidate) continue;

            if (DFS(graph, person, candidate, new HashSet<int>()))
                count++;
        }

        return count == n - 1 ? candidate : -1;
    }

    private bool DFS(Dictionary<int, List<int>> graph, int current, int target, HashSet<int> visited)
    {
        if (current == target) return true;
        if (visited.Contains(current)) return false;

        visited.Add(current);
        foreach (var neighbor in graph[current])
        {
            if (DFS(graph, neighbor, target, visited))
                return true;
        }

        return false;
    }
}
