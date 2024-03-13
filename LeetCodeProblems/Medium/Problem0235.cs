using LeetCodeProblems.Easy;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree'>Lowest Common Ancestor of a Binary Search Tree</see>
    /// <br>Tree, Depth-First Search, Binary Search Tree, Binary Tree</br>
    /// </summary>
    internal class Problem0235
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            var current = root;

            while (current != null)
            {
                if (current.val < p.val && current.val < q.val)
                {
                    current = current.right;
                }
                else if (current.val > p.val && current.val > q.val)
                {
                    current = current.left;
                }
                else
                {
                    return current;
                }
            }

            return current;
        }
    }
}
