namespace LC_141_LinkedListCycle;

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
    public bool HasCycle(ListNode head)
    {
        ListNode fast = head, slow = head;

        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast)
                return true;
        }

        return false;
    }
}
