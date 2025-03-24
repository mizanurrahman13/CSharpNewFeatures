using ShortestPathWithLetLon;

var graph = new Graph();

// Define nodes
var nodeA = new Node("A", 23.8103, 90.4125);
var nodeB = new Node("B", 23.8144, 90.4147);
var nodeC = new Node("C", 23.8178, 90.4198);

// Add nodes to the graph
graph.AddNode(nodeA);
graph.AddNode(nodeB);
graph.AddNode(nodeC);

// Define neighbors
graph.AddNeighbor(nodeA, nodeB);
graph.AddNeighbor(nodeB, nodeC);
graph.AddNeighbor(nodeC, nodeA);

// Find the shortest path
var shortestPath = graph.FindShortestPath(nodeA, nodeC);

// Print the path
Console.WriteLine("Shortest Path:");
foreach (var node in shortestPath)
{
    Console.WriteLine($"{node.Name} ({node.Latitude}, {node.Longitude})");
}
