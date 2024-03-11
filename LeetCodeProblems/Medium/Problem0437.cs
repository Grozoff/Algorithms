using LeetCodeProblems.Easy;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/path-sum-iii">Path Sum III</see>
    /// <br>Tree, Depth-First Search, Binary Tree</br>
    /// </summary>
    internal class Problem0437
    {
        public int PathSum(TreeNode root, int targetSum)
        {
            if (root == null) return 0;

            return Dfs(root, targetSum) + PathSum(root.left, targetSum) + PathSum(root.right, targetSum);
        }

        private int Dfs(TreeNode node, long target)
        {
            if (node == null) return 0;

            return (node.val == target ? 1 : 0) + Dfs(node.left, target - node.val) + Dfs(node.right, target - node.val);
        }
    }
}
