namespace LC_109_ConvertSortedListtoBinarySearchTree;


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

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int value = 0, TreeNode leftNode = null, TreeNode rightNode = null)
    {
        val = value;
        left = leftNode;
        right = rightNode;
    }
}

public class Solution
{
    public TreeNode SortedListToBST(ListNode head)
    {
        if (head == null) return null; // Base case

        // Step 1: Find the middle of the linked list
        ListNode mid = FindMiddle(head);

        // Step 2: Create the root node of the BST with the middle value
        TreeNode root = new TreeNode(mid.val);

        // Base case: If the middle is the head, we return it as the root
        if (head == mid) return root;

        // Step 3: Recursively construct the left and right subtrees
        root.left = SortedListToBST(GetLeftHalf(head, mid));
        root.right = SortedListToBST(mid.next);

        return root;
    }

    private ListNode FindMiddle(ListNode head)
    {
        ListNode prev = null, slow = head, fast = head;

        while (fast != null && fast.next != null)
        {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }

        // Disconnect the left half from the middle
        if (prev != null)
        {
            prev.next = null;
        }

        return slow;
    }

    private ListNode GetLeftHalf(ListNode head, ListNode mid)
    {
        ListNode current = head;

        // Traverse until just before the middle
        while (current != null && current.next != mid)
        {
            current = current.next;
        }

        // Disconnect the middle
        if (current != null) current.next = null;
        return head;
    }
}
