namespace LeetCodeProblems.Easy
{
    internal class Problem0543
    {
        public int result;

        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null) return 0;

            MaxDepth(root);
            return result;
        }

        private int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            var maxL = Math.Max(MaxDepth(root.left), 0);
            var maxR = Math.Max(MaxDepth(root.right), 0);
            result = Math.Max(result, maxL + maxR);

            return Math.Max(maxR, maxL) + 1;
        }
    }

    public class Tests0543
    {
        [Test]
        public void Test1()
        {
            var p = new Problem0543();
            // [1,2,3,4,5]
            var input = new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2,
                    left = new TreeNode()
                    {
                        val = 4,
                    },
                    right = new TreeNode()
                    {
                        val = 5,
                    }
                },
                right = new TreeNode()
                {
                    val = 3,
                }
            };
            var output = p.DiameterOfBinaryTree(input);

            Assert.That(output, Is.EqualTo(3));
        }

        [Test]
        public void Test2()
        {
            var p = new Problem0543();
            // [1,2,3,4,5]
            var input = new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2
                }
            };
            var output = p.DiameterOfBinaryTree(input);

            Assert.That(output, Is.EqualTo(1));
        }
    }
}
