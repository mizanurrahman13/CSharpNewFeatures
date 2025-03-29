namespace LC_138_CopyListwithRandomPointer;

public class Node
{
    public int val;
    public Node next;
    public Node random;

    public Node(int value = 0, Node nextNode = null, Node randomNode = null)
    {
        val = value;
        next = nextNode;
        random = randomNode;
    }
}
public class Solution
{
    public Node CopyRandomList(Node head) 
    {
        if (head is null) return null;

        Dictionary<Node, Node> nodeMap = new Dictionary<Node, Node>();

        Node current = head;
        while(current != null) 
        {
            nodeMap[current] = new Node(current.val);
            current = current.next;
        }

        current = head;
        while (current != null) 
        {
            if (current.next != null)
            {
                nodeMap[current].next = nodeMap[current.next];
            }
            if (current.random != null)
            {
                nodeMap[current].random = nodeMap[current.random];
            }
            current = current.next;
        }

        return nodeMap[head];
    }

    public List<List<object>> ToOutputFormat(Node head)
    {
        var result = new List<List<object>>();
        var nodeIndexMap = new Dictionary<Node, int>();
        var nodes = new List<Node>();

        // Build a list of nodes and map them to indices
        Node current = head;
        int index = 0;
        while (current != null)
        {
            nodeIndexMap[current] = index++;
            nodes.Add(current);
            current = current.next;
        }

        // Build the result output
        foreach (var node in nodes)
        {
            int? randomIndex = node.random != null ? nodeIndexMap[node.random] : null;
            result.Add(new List<object> { node.val, randomIndex });
        }

        return result;
    }
}
