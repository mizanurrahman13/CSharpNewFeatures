namespace LC_2_AddTwoNumbers;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int value = 0, ListNode nextNode = null)
    {
        val = value;
        next = nextNode;
    }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummyHead = new ListNode(0); // Dummy head for the result linked list
        ListNode current = dummyHead;        // Pointer to traverse the result linked list
        int carry = 0;                       // Store carry for addition

        // Traverse both linked lists
        while (l1 != null || l2 != null || carry != 0)
        {
            int sum = carry; // Start with carry

            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next; // Move to the next node in l1
            }

            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next; // Move to the next node in l2
            }

            carry = sum / 10; // Calculate carry for the next digit
            current.next = new ListNode(sum % 10); // Add the digit to the result
            current = current.next; // Move the pointer in the result list
        }

        return dummyHead.next; // Skip the dummy head and return the actual result
    }
}
