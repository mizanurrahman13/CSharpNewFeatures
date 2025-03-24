namespace _653_TwoSumIV_InputisaBST;

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
    public bool FindTarget(TreeNode root, int k)
    {
        if (root == null) return false;

        var seen = new HashSet<int>(); // Stores visited values
        var queue = new Queue<TreeNode>(); // Queue for level-order traversal
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var currentNode = queue.Dequeue();

            // Check if the complement exists in the HashSet
            if (seen.Contains(k - currentNode.val))
            {
                return true; // Found two numbers that add up to k
            }

            // Add current value to the set
            seen.Add(currentNode.val);

            // Add left and right children to the queue for processing
            if (currentNode.left != null) queue.Enqueue(currentNode.left);
            if (currentNode.right != null) queue.Enqueue(currentNode.right);
        }

        return false; // No pair found
    }

    //public bool FindTarget(TreeNode root, int k)
    //{
    //    var seen = new HashSet<int>(); // HashSet to store visited values
    //    return DFS(root, k, seen);    // Call the helper method for DFS traversal
    //}

    //private bool DFS(TreeNode node, int k, HashSet<int> seen)
    //{
    //    if (node == null)
    //    {
    //        return false; // Base case: If the node is null, return false
    //    }

    //    // Check if the complement of the current node's value (k - node.val) exists in the set
    //    if (seen.Contains(k - node.val))
    //    {
    //        return true; // If it exists, we've found two numbers that add up to k
    //    }

    //    // Add the current node's value to the set
    //    seen.Add(node.val);

    //    // Recursively check the left and right subtrees
    //    return DFS(node.left, k, seen) || DFS(node.right, k, seen);
    //}
}

