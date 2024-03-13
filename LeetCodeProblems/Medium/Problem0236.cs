using LeetCodeProblems.Easy;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree'>Lowest Common Ancestor of a Binary Tree</see>
    /// <br>Tree, Depth-First Search, Binary Tree</br>
    /// </summary>
    internal class Problem0236
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || root == p || root == q) return root;
            var left = LowestCommonAncestor(root.left, p, q);
            var right = LowestCommonAncestor(root.right, p, q);
            if (right != null && left != null) return root;
            return right ?? left;
        }
    }
}
