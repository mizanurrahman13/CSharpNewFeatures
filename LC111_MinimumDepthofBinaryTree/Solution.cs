namespace LC111_MinimumDepthofBinaryTree;

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
    /// <summary>
    /// BFS
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int MinDepth(TreeNode root)
    {
        if (root is null)
            return 0;

        if (root.left is null && root.right is null)
            return 1;

        if(root.left is null)
            return MinDepth(root.right) + 1;

        if (root.right is null)
            return MinDepth(root.left) + 1;

        return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
    }
}
