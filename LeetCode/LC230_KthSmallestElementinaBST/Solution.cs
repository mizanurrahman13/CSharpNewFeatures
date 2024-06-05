namespace LC230_KthSmallestElementinaBST;


public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public int KthSmallest(TreeNode root, int k)
    {
        int target = 0;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode current = root;

        while (current != null || stack.Any())
        {
            while (current != null)
            {
                stack.Push(current);
                current = current.left;
            }

            current = stack.Pop();
            target++;
            if (target == k)
                return current.val;
            current = current.right;
        }

        return -1;
    }
}
