using LeetCodeProblems.Easy;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/find-bottom-left-tree-value">Find Bottom Left Tree Value</see>
    /// <br>Tree, Depth-First Search, Breadth-First Search, Binary Tree</br>
    /// </summary>
    internal class Problem0513
    {
        public int FindBottomLeftValue(TreeNode root)
        {
            if (root == null) return 0;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            var node = root;
            while (queue.Count > 0)
            {
                node = queue.Dequeue();
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
            }

            return node.val;
        }
    }
}
