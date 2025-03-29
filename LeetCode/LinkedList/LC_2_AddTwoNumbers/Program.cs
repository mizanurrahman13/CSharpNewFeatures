using LC_2_AddTwoNumbers;

ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3))); // Represents number 342
ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4))); // Represents number 465

Solution solution = new Solution();
ListNode result = solution.AddTwoNumbers(l1, l2);

// Print result as a linked list
while (result != null)
{
    Console.Write(result.val + " ");
    result = result.next;
}
// Output: 7 0 8 (Represents 807, which is 342 + 465)
