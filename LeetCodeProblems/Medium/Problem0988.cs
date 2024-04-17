using LeetCodeProblems.Easy;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/smallest-string-starting-from-leaf">Smallest String Starting From Leaf</see>
    /// <br>Tree, Depth-First Search, String, Binary Tree</br>
    /// </summary>
    internal class Problem0988
    {
        private string result = "";

        public string SmallestFromLeaf(TreeNode root)
        {
            DFS(root, "");
            return result;
        }

        private void DFS(TreeNode node, string path)
        {
            if (node == null) return;

            path = (char)('a' + node.val) + path;

            if (node.left == null && node.right == null)
            {
                if (string.Compare(path, result) < 0 || result == "")
                {
                    result = path;
                }
            }

            DFS(node.left, path);
            DFS(node.right, path);
        }
    }
}
