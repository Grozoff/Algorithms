using LeetCodeProblems.Easy;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/maximum-difference-between-node-and-ancestor/'>Maximum Difference Between Node and Ancestor</see>
    /// <br>Tree, Depth-First Search, Binary Tree</br>
    /// </summary>
    internal class Problem1026
    {
        public int MaxAncestorDiff(TreeNode root)
        {
            return MaxAncestorDiffHelper(root, int.MaxValue, int.MinValue);
        }

        private int MaxAncestorDiffHelper(TreeNode node, int minSoFar, int maxSoFar)
        {
            if (node == null)
            {
                return maxSoFar - minSoFar;
            }

            int newMin = Math.Min(minSoFar, node.val);
            int newMax = Math.Max(maxSoFar, node.val);

            int leftDiff = MaxAncestorDiffHelper(node.left, newMin, newMax);
            int rightDiff = MaxAncestorDiffHelper(node.right, newMin, newMax);

            return Math.Max(leftDiff, rightDiff);
        }
    }
}
