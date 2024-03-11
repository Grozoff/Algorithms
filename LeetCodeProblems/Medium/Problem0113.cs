using LeetCodeProblems.Easy;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/path-sum-ii">Path Sum II</see>
    /// <br>Backtracking, Tree, Depth-First Search, Binary Tree</br>
    /// </summary>
    internal class Problem0113
    {
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            var result = new List<IList<int>>();
            Dfs(root, targetSum, [], result);
            return result;
        }

        private void Dfs(TreeNode node, int target, List<int> path, List<IList<int>> result)
        {
            if (node == null) return;
            path.Add(node.val);
            if (node.left == null && node.right == null && target == node.val)
                result.Add(new List<int>(path));
            Dfs(node.left, target - node.val, path, result);
            Dfs(node.right, target - node.val, path, result);
            path.RemoveAt(path.Count - 1);
        }
    }
}
