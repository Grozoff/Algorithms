using LeetCodeProblems.Easy;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/validate-binary-search-tree'>Validate Binary Search Tree</see>
    /// <br>Tree, Depth-First Search, Binary Search Tree, Binary Tree</br>
    /// </summary>
    internal class Problem0098
    {
        // It is not my solution, but now I know how it works
        public static bool IsValidBST(TreeNode root)
        {
            return Validate(root, long.MinValue, long.MaxValue);
        }

        private static bool Validate(TreeNode node, long min, long max)
        {
            if (node == null)
            {
                return true;
            }

            return (
                node.val > min &&
                node.val < max &&
                Validate(node.left, min, node.val) &&
                Validate(node.right, node.val, max)
            );
        }
    }

    public class Tests0098
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
            var output = Problem0098.IsValidBST(input);

            Assert.False(output);
        }
    }
}
