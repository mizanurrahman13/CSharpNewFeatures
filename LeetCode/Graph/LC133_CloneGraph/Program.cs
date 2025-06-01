// Creating a sample graph: 1 - 2, 1 - 4, 2 - 3, 3 - 4
using LC133_CloneGraph;

Node node1 = new Node(1);
Node node2 = new Node(2);
Node node3 = new Node(3);
Node node4 = new Node(4);

node1.neighbors.Add(node2);
node1.neighbors.Add(node4);
node2.neighbors.Add(node1);
node2.neighbors.Add(node3);
node3.neighbors.Add(node2);
node3.neighbors.Add(node4);
node4.neighbors.Add(node1);
node4.neighbors.Add(node3);

Solution cloner = new Solution();
Node clonedGraph = cloner.CloneGraph(node1);

// Display cloned graph
Console.WriteLine($"Cloned Node: {clonedGraph.val}");
foreach (var neighbor in clonedGraph.neighbors)
{
    Console.WriteLine($"Neighbor of {clonedGraph.val}: {neighbor.val}");
}
