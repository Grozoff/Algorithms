using LeetCodeProblems.Easy;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/longest-zigzag-path-in-a-binary-tree'>Longest ZigZag Path in a Binary Tree</see>
    /// <br>Dynamic Programming, Tree, Depth-First Search, Binary Tree</br>
    /// </summary>
    internal class Problem1372
    {
        int result = 0;
        public int LongestZigZag(TreeNode root)
        {
            ZigZag(root, true, 0);
            ZigZag(root, false, 0);
            return result;
        }

        private void ZigZag(TreeNode node, bool isRight, int path)
        {
            if (node == null) return;

            result = Math.Max(result, path);
            if (isRight)
            {
                ZigZag(node.left, true, 1);
                ZigZag(node.right, false, path + 1);
            }
            else
            {
                ZigZag(node.left, true, path + 1);
                ZigZag(node.right, false, 1);
            }
        }
    }
}
