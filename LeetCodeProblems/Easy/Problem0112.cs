namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/path-sum">Path Sum</see>
    /// <br>Tree, Depth-First Search, Breadth-First Search, Binary Tree</br>
    /// </summary>
    internal class Problem0112
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            return Dfs(root, targetSum, 0);
        }

        private bool Dfs(TreeNode node, int target, int current)
        {
            if (node == null) return false;

            current += node.val;
            if (node.left == null && node.right == null)
                return current == target;

            return Dfs(node.left, target, current) || Dfs(node.right, target, current);
        }
    }
}
