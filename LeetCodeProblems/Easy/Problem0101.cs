namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/symmetric-tree/'>Symmetric Tree</see>
    /// <br>Tree, Depth-First Search, Breadth-First Search, Binary Tree</br>
    /// </summary>
    internal class Problem0101
    {
        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;

            return IsMirror(root.left, root.right);
        }

        private static bool IsMirror(TreeNode left, TreeNode right)
        {
            if (left == null && right == null) return true;

            if (left?.val != right?.val) return false;

            return IsMirror(left.left, right.right) && IsMirror(right.left, left.right);
        }
    }

    public class Tests0101
    {
        [Test]
        public void Test1()
        {
            // [1,2,2,null,3,null,3]
            var input = new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2,
                    right = new TreeNode()
                    {
                        val = 3,
                    }
                },
                right = new TreeNode()
                {
                    val = 2,
                    right = new TreeNode()
                    {
                        val = 3,
                    }
                }
            };
            var output = Problem0101.IsSymmetric(input);

            Assert.False(output);
        }

        [Test]
        public void Test2()
        {
            // [2,3,3,4,5,null,4]
            var input = new TreeNode()
            {
                val = 2,
                left = new TreeNode()
                {
                    val = 3,
                    left = new TreeNode()
                    {
                        val = 4
                    },
                    right = new TreeNode()
                    {
                        val = 5,
                    }
                },
                right = new TreeNode()
                {
                    val = 3,
                    right = new TreeNode()
                    {
                        val = 4,
                    }
                }
            };
            var output = Problem0101.IsSymmetric(input);

            Assert.False(output);
        }
    }
}
