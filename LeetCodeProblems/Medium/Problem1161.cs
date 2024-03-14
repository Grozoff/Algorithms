using LeetCodeProblems.Easy;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/maximum-level-sum-of-a-binary-tree'>Maximum Level Sum of a Binary Tree</see>
    /// <br>Tree, Depth-First Search, Breadth-First Search, Binary Tree</br>
    /// </summary>
    internal class Problem1161
    {
        public int MaxLevelSum(TreeNode root)
        {
            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            var max = int.MinValue;
            var result = 0;
            var depth = 0;
            while (q.Count > 0)
            {
                var count = q.Count;
                var curMax = 0;
                for (int i = 0; i < count; i++)
                {
                    var node = q.Dequeue();
                    curMax += node.val;
                    if (node.left != null)
                    {
                        q.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        q.Enqueue(node.right);
                    }
                }
                depth++;
                if (curMax > max)
                {
                    max = curMax;
                    result = depth;
                }
            }
            return result;
        }
    }
}
