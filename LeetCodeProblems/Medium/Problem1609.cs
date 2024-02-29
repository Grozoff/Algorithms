using LeetCodeProblems.Easy;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/even-odd-tree'>Even Odd Tree</see>
    /// <br>Tree, Breadth-First Search, Binary Tree</br>
    /// </summary>
    internal class Problem1609
    {
        public bool IsEvenOddTree(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var values = new List<int>();
            var layers = 0;
            while (queue.Count > 0)
            {
                var count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    values.Add(node.val);
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }

                layers++;

                if (layers % 2 == 0)
                {
                    var prev = int.MaxValue - 1;
                    foreach (var val in values)
                    {
                        if (val >= prev || val % 2 != 0)
                            return false;
                        prev = val;
                    }
                }
                else
                {
                    var prev = int.MinValue;
                    foreach (var val in values)
                    {
                        if (val <= prev || val % 2 == 0)
                            return false;
                        prev = val;
                    }
                }

                values.Clear();
            }

            return true;
        }
    }
}
