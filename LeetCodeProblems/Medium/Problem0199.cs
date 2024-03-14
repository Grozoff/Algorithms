using LeetCodeProblems.Easy;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/binary-tree-right-side-view'>Binary Tree Right Side View</see>
    /// <br>Tree, Depth-First Search, Breadth-First Search, Binary Tree</br>
    /// </summary>
    internal class Problem0199
    {
        public IList<int> RightSideView(TreeNode root)
        {
            if (root == null) return [];

            var result = new List<int>();

            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                var count = q.Count;
                for (int i = 0; i < count; i++)
                {
                    var node = q.Dequeue();
                    if (node.left != null)
                    {
                        q.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        q.Enqueue(node.right);
                    }
                    if (i + 1 == count)
                        result.Add(node.val);
                }
            }
            return result;
        }
    }
}
