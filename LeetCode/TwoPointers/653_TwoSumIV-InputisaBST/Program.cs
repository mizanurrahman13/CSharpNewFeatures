using _653_TwoSumIV_InputisaBST;

var root = new TreeNode(5,
    new TreeNode(3,
        new TreeNode(2),
        new TreeNode(4)),
    new TreeNode(6,
        null,
        new TreeNode(7)));

var solution = new Solution();
bool result = solution.FindTarget(root, 9);
Console.WriteLine(result); // Output: True (3 + 6 = 9)

result = solution.FindTarget(root, 28);
Console.WriteLine(result); // Output: False

