// Create a linked list: [3, 2, 0, -4] with cycle at pos = 1
using LC_142_LinkedListCycleII;

ListNode head = new ListNode(3);
ListNode second = new ListNode(2);
ListNode third = new ListNode(0);
ListNode fourth = new ListNode(-4);

head.next = second;
second.next = third;
third.next = fourth;

// Create a cycle at pos = 1
fourth.next = second;

Solution solution = new Solution();
ListNode cycleStart = solution.DetectCycle(head);

if (cycleStart != null)
{
    Console.WriteLine($"Cycle starts at node with value: {cycleStart.val}");
}
else
{
    Console.WriteLine("No cycle detected.");
}
