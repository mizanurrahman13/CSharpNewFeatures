// Step 1: Create the linked list [3, 2, 0, -4]
using LC_141_LinkedListCycle;

ListNode head = new ListNode(3);
ListNode second = new ListNode(2);
ListNode third = new ListNode(0);
ListNode fourth = new ListNode(-4);

head.next = second;
second.next = third;
third.next = fourth;

// Step 2: Create a cycle at pos = 1 (second node)
fourth.next = second;

// Step 3: Use Solution to detect cycle
Solution solution = new Solution();
bool hasCycle = solution.HasCycle(head);

// Output the result
Console.WriteLine(hasCycle ? "Cycle detected." : "No cycle detected.");
