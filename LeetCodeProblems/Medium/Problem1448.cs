using LeetCodeProblems.Easy;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/count-good-nodes-in-binary-tree">Count Good Nodes in Binary Tree</see>
    /// <br>Tree, Depth-First Search, Breadth-First Search, Binary Tree</br>
    /// </summary>
    internal class Problem1448
    {
        public int result = 0;
        public int GoodNodes(TreeNode root)
        {
            Calc(root, root.val);
            return result;
        }

        private void Calc(TreeNode current, int prev)
        {
            if (current == null) return;
            if (current.val >= prev)
                result++;
            Calc(current.left, Math.Max(current.val, prev));
            Calc(current.right, Math.Max(current.val, prev));
        }
    }
}
