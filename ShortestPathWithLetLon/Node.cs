namespace ShortestPathWithLetLon;

public class Node
{
    public string Name { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public List<Node> Neighbors { get; set; } = new List<Node>();

    public Node(string name, double latitude, double longitude)
    {
        Name = name;
        Latitude = latitude;
        Longitude = longitude;
    }
}

public static class GeoUtils
{
    public static double HaversineDistance(double lat1, double lon1, double lat2, double lon2)
    {
        const double R = 6371; // Earth's radius in kilometers
        var dLat = DegreesToRadians(lat2 - lat1);
        var dLon = DegreesToRadians(lon2 - lon1);
        var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Cos(DegreesToRadians(lat1)) * Math.Cos(DegreesToRadians(lat2)) *
                Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
        var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        return R * c;
    }

    private static double DegreesToRadians(double degrees)
    {
        return degrees * Math.PI / 180;
    }
}

public class Graph
{
    private List<Node> _allNodes = new List<Node>();

    public void AddNode(Node node)
    {
        if (!_allNodes.Contains(node))
        {
            _allNodes.Add(node);
        }
    }

    public void AddNeighbor(Node fromNode, Node toNode)
    {
        if (!fromNode.Neighbors.Contains(toNode))
        {
            fromNode.Neighbors.Add(toNode);
        }
    }

    public List<Node> GetAllNodes()
    {
        return _allNodes;
    }

    public List<Node> FindShortestPath(Node startNode, Node targetNode)
    {
        var distances = new Dictionary<Node, double>();
        var previousNodes = new Dictionary<Node, Node>();
        var unvisitedNodes = new HashSet<Node>(_allNodes);

        foreach (var node in _allNodes)
        {
            distances[node] = double.PositiveInfinity;
        }
        distances[startNode] = 0;

        while (unvisitedNodes.Count > 0)
        {
            // Get the node with the smallest distance
            var currentNode = unvisitedNodes.OrderBy(n => distances[n]).First();

            if (currentNode == targetNode)
            {
                break;
            }

            unvisitedNodes.Remove(currentNode);

            // Update distances for neighbors
            foreach (var neighbor in currentNode.Neighbors)
            {
                double distance = distances[currentNode] + GeoUtils.HaversineDistance(
                    currentNode.Latitude, currentNode.Longitude,
                    neighbor.Latitude, neighbor.Longitude);

                if (distance < distances[neighbor])
                {
                    distances[neighbor] = distance;
                    previousNodes[neighbor] = currentNode;
                }
            }
        }

        // Build the shortest path
        var path = new List<Node>();
        var current = targetNode;

        while (current != null)
        {
            path.Add(current);
            previousNodes.TryGetValue(current, out current);
        }

        path.Reverse();
        return path;
    }
}
