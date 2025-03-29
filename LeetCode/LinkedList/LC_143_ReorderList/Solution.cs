namespace LC_143_ReorderList;


public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
      this.val = val;
      this.next = next;
    }
}
public class Solution
{
    public void ReorderList(ListNode head)
    {
        ListNode slow = head, fast = head.next;

        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode second = slow.next;
        ListNode prev = slow.next = null;

        while (second != null)
        {
            ListNode tmp = second.next;
            second.next = prev;
            prev = second;
            second = tmp;
        }

        // merge two halfs
        fast = head;
        second = prev;

        while (second != null)
        {
            ListNode tmp1 = fast.next, tmp2 = second.next;
            fast.next = second;
            second.next = tmp1;
            fast = tmp1;
            second = tmp2;

        }
    }
}
