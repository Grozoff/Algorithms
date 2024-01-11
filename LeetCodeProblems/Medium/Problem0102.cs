using LeetCodeProblems.Easy;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/binary-tree-level-order-traversal/'>Binary Tree Level Order Traversal</see>
    /// <br>Tree, Breadth-First Search, Binary Tree</br>
    /// </summary>
    internal class Problem0102
    {
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null) return new List<IList<int>>();

            var q = new Queue<TreeNode>();
            q.Enqueue(root);

            var result = new List<IList<int>>();

            while (q.Count > 0)
            {
                var count = q.Count;
                var innerList = new List<int>();
                for (int i = 0; i < count; i++)
                {
                    var node = q.Dequeue();
                    innerList.Add(node.val);
                    if (node.left != null)
                        q.Enqueue(node.left);

                    if (node.right != null)
                        q.Enqueue(node.right);
                }

                result.Add(innerList);
            }

            return result;
        }
    }

    public class Tests0102
    {
        [Test]
        public void Test()
        {
            // [5,4,6,null,null,3,7]
            var input = new TreeNode()
            {
                val = 5,
                left = new TreeNode()
                {
                    val = 4,
                },
                right = new TreeNode()
                {
                    val = 6,
                    left = new TreeNode()
                    {
                        val = 3
                    },
                    right = new TreeNode()
                    {
                        val = 7
                    }
                }
            };
            var output = Problem0102.LevelOrder(input);
        }
    }
}
