using LeetCodeProblems.Easy;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/add-one-row-to-tree">Add One Row to Tree</see>
    /// <br>Tree, Depth-First Search, Breadth-First Search, Binary Tree</br>
    /// </summary>
    internal class Problem0623
    {
        public TreeNode AddOneRow(TreeNode root, int val, int depth)
        {
            if (depth == 1) return new TreeNode { val = val, left = root };
            var d = 0;
            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0 && d < depth - 2)
            {
                var count = q.Count;
                for (int i = 0; i < count; i++)
                {
                    var node = q.Dequeue();
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                }
                d++;
            }

            while (q.Count > 0)
            {
                var node = q.Dequeue();
                var left = new TreeNode(val);
                left.left = node.left;
                node.left = left;

                var right = new TreeNode(val);
                right.right = node.right;
                node.right = right;
            }

            return root;
        }

        public TreeNode AddOneRowV2(TreeNode root, int val, int depth)
        {
            if (depth == 1)
            {
                return new TreeNode(val, root, null);
            }

            Dfs(root, 1, depth, val);

            return root;

        }

        private void Dfs(TreeNode node, int currentDepth, int targetDepth, int val)
        {
            if (node == null)
            {
                return;
            }

            if (currentDepth == targetDepth - 1)
            {
                TreeNode newLeft = new TreeNode(val, node.left, null);
                TreeNode newRight = new TreeNode(val, null, node.right);
                node.left = newLeft;
                node.right = newRight;
                return;
            }

            Dfs(node.left, currentDepth + 1, targetDepth, val);
            Dfs(node.right, currentDepth + 1, targetDepth, val);
        }
    }
}
