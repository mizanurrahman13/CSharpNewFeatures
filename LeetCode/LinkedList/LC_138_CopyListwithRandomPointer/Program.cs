// Create a sample linked list: [7,null] -> [13,0] -> [11,4] -> [10,2] -> [1,0]
using LC_138_CopyListwithRandomPointer;

Node head = new Node(7);
head.next = new Node(13);
head.next.random = head;
head.next.next = new Node(11);
head.next.next.random = head.next.next.next;
head.next.next.next = new Node(10);
head.next.next.next.random = head.next;
head.next.next.next.next = new Node(1);
head.next.next.next.next.random = head;

Solution solution = new Solution();
Node copiedList = solution.CopyRandomList(head);

// Print the output in the desired format
var output = solution.ToOutputFormat(copiedList);
foreach (var node in output)
{
    Console.WriteLine($"[{node[0]},{(node[1] == null ? "null" : node[1])}]");
}
