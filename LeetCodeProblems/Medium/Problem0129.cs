using LeetCodeProblems.Easy;

namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/sum-root-to-leaf-numbers/">Sum Root to Leaf Numbers</see>
    /// <br>Tree, Depth-First Search, Binary Tree</br>
    /// </summary>
    internal class Problem0129
    {
        public int SumNumbers(TreeNode root, int currentSum = 0)
        {
            if (root == null) return 0;
            var sum = root.val + (currentSum * 10);
            if (root.left == null && root.right == null) return sum;
            var l = SumNumbers(root.left, sum);
            var r = SumNumbers(root.right, sum);
            return l + r;
        }
    }
}
