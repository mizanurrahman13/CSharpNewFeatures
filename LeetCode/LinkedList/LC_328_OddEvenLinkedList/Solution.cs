namespace LC_328_OddEvenLinkedList;

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
    public ListNode OddEvenList(ListNode head)
    {
        if (head == null || head.next == null) return head; // Base case: Empty list or single node

        ListNode odd = head;             // Pointer for odd-indexed nodes
        ListNode even = head.next;       // Pointer for even-indexed nodes
        ListNode evenHead = even;        // Store the head of even list to attach later

        while (even != null && even.next != null)
        {
            odd.next = even.next;        // Link current odd to the next odd node
            odd = odd.next;              // Move odd pointer to the next odd node

            even.next = odd.next;        // Link current even to the next even node
            even = even.next;            // Move even pointer to the next even node
        }

        odd.next = evenHead;             // Attach the even list to the end of the odd list
        return head;
    }
}

