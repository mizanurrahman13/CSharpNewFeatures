// Create the linked list [1, 2, 3, 4, 5]
using LC_143_ReorderList;

ListNode head = new ListNode(1);
head.next = new ListNode(2);
head.next.next = new ListNode(3);
head.next.next.next = new ListNode(4);
head.next.next.next.next = new ListNode(5);

// Apply ReorderList function
Solution solution = new Solution();
solution.ReorderList(head);

// Print the reordered list
PrintList(head);

static void PrintList(ListNode head)
{
    ListNode current = head;
    while (current != null)
    {
        Console.Write(current.val);
        if (current.next != null)
            Console.Write(" -> ");
        current = current.next;
    }
    Console.WriteLine();
}