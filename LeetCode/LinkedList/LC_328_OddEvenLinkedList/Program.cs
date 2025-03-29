// Create a sample linked list: 1 -> 2 -> 3 -> 4 -> 5
using LC_328_OddEvenLinkedList;

ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

Solution solution = new Solution();
ListNode result = solution.OddEvenList(head);

// Print the result: 1 -> 3 -> 5 -> 2 -> 4
while (result != null)
{
    Console.Write(result.val + " ");
    result = result.next;
}
