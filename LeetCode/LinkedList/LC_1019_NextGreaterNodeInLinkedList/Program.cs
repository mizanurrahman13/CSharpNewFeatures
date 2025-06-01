// Input: head = [2,1,5]
using LC_1019_NextGreaterNodeInLinkedList;

ListNode head = new ListNode(2, new ListNode(1, new ListNode(5)));

Solution solution = new Solution();
int[] result = solution.NextLargerNodes(head);

// Output the results
Console.WriteLine("Output: [" + string.Join(",", result) + "]");
