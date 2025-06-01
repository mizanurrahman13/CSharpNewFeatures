using LC19_RemoveNthNodeFromEndofList;

// Input: head = [1,2,3,4,5], n = 2
ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
int n = 2;

Solution solution = new Solution();
ListNode result = solution.RemoveNthFromEnd(head, n);

// Output: [1,2,3,5]
Console.Write("Output: [");
while (result != null)
{
    Console.Write(result.val);
    if (result.next != null)
    {
        Console.Write(",");
    }
    result = result.next;
}
Console.WriteLine("]");