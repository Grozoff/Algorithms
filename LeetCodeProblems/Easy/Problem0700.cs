namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/search-in-a-binary-search-tree'>Search in a Binary Search Tree</see>
    /// <br>Tree, Binary Search Tree, Binary Tree</br>
    /// </summary>
    internal class Problem0700
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null || root.val == val) return root;

            if (root.val < val)
            {
                return SearchBST(root.right, val);
            }
            else
            {
                return SearchBST(root.left, val);
            }
        }
    }
}
