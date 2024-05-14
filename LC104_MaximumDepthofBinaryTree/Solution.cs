namespace LC104_MaximumDepthofBinaryTree;

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
    public int MaxDepth(TreeNode root)
    {
        if (root is null)
            return 0;

        var leftMaxDepth = MaxDepth(root.left);
        var rightMaxDepth = MaxDepth(root.right);

        return Math.Max(leftMaxDepth, rightMaxDepth) + 1;
    }

    /// <summary>
    /// DFS
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    //public int MaxDepth(TreeNode root)
    //{
    //    if (root is null)
    //        return 0;

    //    var queue = new Queue<TreeNode>();
    //    queue.Enqueue(root);

    //    int maxDepth = 0;

    //    while (queue.Count != 0)
    //    {
    //        int length = queue.Count;

    //        for (int i = 0; i < length; i++)
    //        {
    //            var current = queue.Dequeue();
    //            if (current.left is not null)
    //                queue.Enqueue(current.left);

    //            if (current.right is not null)
    //                queue.Enqueue(current.right);
    //        }

    //        maxDepth++;
    //    }

    //    return maxDepth;
    //}
}
