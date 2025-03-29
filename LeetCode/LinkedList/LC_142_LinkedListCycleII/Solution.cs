namespace LC_142_LinkedListCycleII;

/// <summary>
/// Floyd's Tortoise and Hare Algorithm
/// The HasCycle method is called, which uses the Floyd's Tortoise and Hare algorithm:

///1. Two pointers, slow and fast, traverse the list.

///2. If they meet, a cycle exists.If fast reaches the end of the list (null), no cycle exists.
/// </summary>
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}
public class Solution
{
    public ListNode DetectCycle(ListNode head)
    {
        if (head == null) return null;

        ListNode fast = head, slow = head;

        // Step 1: Detect cycle using two pointers
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            // If a cycle is detected
            if (slow == fast)
            {
                // Step 2: Find the start of the cycle
                ListNode cycleStart = head;
                int nodeIndex = 0;

                while (cycleStart != slow)
                {
                    cycleStart = cycleStart.next;
                    slow = slow.next;
                    nodeIndex++;
                }

                Console.WriteLine($"tail connects to node index {nodeIndex}");
                return cycleStart; // Return the node where the cycle begins
            }
        }

        // If no cycle exists
        Console.WriteLine("no cycle");
        return null;
    }
}