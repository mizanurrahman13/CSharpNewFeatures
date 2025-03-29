// Create a sorted linked list: 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7
using LC_109_ConvertSortedListtoBinarySearchTree;

ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4,
    new ListNode(5, new ListNode(6, new ListNode(7)))))));

Solution solution = new Solution();
TreeNode bstRoot = solution.SortedListToBST(head);

// Traverse the tree (in-order traversal)
PrintTree(bstRoot);


static void PrintTree(TreeNode root)
{
    if (root == null) return;
    PrintTree(root.left);
    Console.WriteLine(root.val);
    PrintTree(root.right);
}
