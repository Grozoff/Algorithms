using LeetCodeProblems.Easy;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/delete-node-in-a-bst'>Delete Node in a BST</see>
    /// <br>Tree, Binary Search Tree, Binary Tree</br>
    /// </summary>
    internal class Problem0450
    {
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null) return root;
            if (root.val < key)
                root.right = DeleteNode(root.right, key);
            else if (root.val > key)
                root.left = DeleteNode(root.left, key);
            else
            {
                if (root.left == null)
                    return root.right;
                if (root.right == null)
                    return root.left;

                var current = root.right;
                while (current.left != null)
                {
                    current = current.left;
                }
                root.val = current.val;
                root.right = DeleteNode(root.right, root.val);
            }

            return root;
        }
    }
}
