namespace LC133_CloneGraph;

public class Node
{
    public int val;
    public IList<Node> neighbors;

    public Node()
    {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val)
    {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors)
    {
        val = _val;
        neighbors = _neighbors;
    }
}

public class Solution
{
    private Dictionary<Node, Node> visited = new Dictionary<Node, Node>();

    public Node CloneGraph(Node node)
    {
        if (node == null)
            return null;

        // If already visited, return cloned node
        if (visited.ContainsKey(node))
            return visited[node];

        // Create a new node
        Node copy = new Node(node.val);
        visited[node] = copy;

        // Clone all neighbors recursively
        foreach (var neighbor in node.neighbors)
            copy.neighbors.Add(CloneGraph(neighbor));

        return copy;
    }
}