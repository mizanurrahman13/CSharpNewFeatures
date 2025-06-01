namespace LC_1019_NextGreaterNodeInLinkedList;

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
    public int[] NextLargerNodes(ListNode head)
    {
        // Step 1: Collect values into a list
        List<int> values = new List<int>();
        while (head != null)
        {
            values.Add(head.val);
            head = head.next;
        }

        int[] result = new int[values.Count];
        Stack<int> stack = new Stack<int>();

        // Step 2: Traverse the list to find next greater element
        for (int i = 0; i < values.Count; i++)
        {
            while (stack.Count > 0 && values[stack.Peek()] < values[i])
            {
                result[stack.Pop()] = values[i];
            }
            stack.Push(i);
        }

        // Remaining indices in the stack have no greater value, so they stay as 0
        return result;
    }
}
