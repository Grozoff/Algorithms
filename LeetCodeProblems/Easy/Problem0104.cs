namespace LeetCodeProblems.Easy
{
    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }


    /// <summary>
    /// <see href="https://leetcode.com/problems/maximum-depth-of-binary-tree/">Maximum Depth of Binary Tree</see>
    /// <br>Tree, Depth-First Search, Breadth-First Search, Binary Tree</br>
    /// </summary>
    internal class Problem0104
    {
        public static int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            var depth = 0;

            while (queue.Count > 0)
            {
                var count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                depth++;
            }

            return depth;

            // shorter version
            if (root is null) return 0;

            var left = MaxDepth(root.left);
            var right = MaxDepth(root.right);

            return 1 + Math.Max(left, right);
        }
    }

    public class Tests0104
    {
        [Test]
        public void Test()
        {
            // [0,2,4,1,null,3,-1,5,1,null,6,null,8]
            var input = new TreeNode()
            {
                val = 0,
                left = new TreeNode()
                {
                    val = 2,
                    left = new TreeNode()
                    {
                        val = 1,
                        left = new TreeNode()
                        {
                            val = 5
                        },
                        right = new TreeNode()
                        {
                            val = 1
                        }
                    }
                },
                right = new TreeNode()
                {
                    val = 4,
                    left = new TreeNode()
                    {
                        val = 3,
                        right = new TreeNode()
                        {
                            val = 6
                        }
                    },
                    right = new TreeNode()
                    {
                        val = -1,
                        right = new TreeNode()
                        {
                            val = 8
                        }
                    }
                }
            };
            var output = Problem0104.MaxDepth(input);

            Assert.That(output, Is.EqualTo(4));
        }
    }
}
