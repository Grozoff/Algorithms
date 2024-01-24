using LeetCodeProblems.Easy;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/pseudo-palindromic-paths-in-a-binary-tree'>Pseudo-Palindromic Paths in a Binary Tree</see>
    /// <br>Bit Manipulation, Tree, Depth-First Search, Breadth-First Search, Binary Tree</br>
    /// </summary>
    internal class Problem1457
    {
        public static int PseudoPalindromicPaths(TreeNode root)
        {
            var count = 0;
            Dfs(root, []);
            return count;

            void Dfs(TreeNode node, HashSet<int> h)
            {
                if (node == null) return;

                if (!h.Add(node.val))
                    h.Remove(node.val);

                if (node.left == null && node.right == null)
                {
                    if (h.Count < 2)
                        count++;
                }
                else
                {
                    Dfs(node.left, h);
                    Dfs(node.right, h);
                }

                if (!h.Remove(node.val))
                    h.Add(node.val);
            }
        }
    }
    public class Tests1457
    {
        [Test]
        public void Test()
        {
            // [2,3,1,3,1,null,1]
            var input = new TreeNode()
            {
                val = 2,
                left = new TreeNode()
                {
                    val = 3,
                    left = new TreeNode() { val = 1 },
                    right = new TreeNode() { val = 3 },
                },
                right = new TreeNode()
                {
                    val = 1,
                    left = new TreeNode() { val = 1 }
                }
            };
            var output = Problem1457.PseudoPalindromicPaths(input);

            Assert.That(output, Is.EqualTo(2));
        }
    }
}
