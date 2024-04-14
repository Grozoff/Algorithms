namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/sum-of-left-leaves/">Sum of Left Leaves</see>
    /// <br>Tree, Depth-First Search, Breadth-First Search, Binary Tree</br>
    /// </summary>
    internal class Problem0404
    {
        int result = 0;

        public int SumOfLeftLeaves(TreeNode root, bool isLeft = false)
        {
            if (root == null) return 0;
            if (root != null && isLeft && root.left == null && root.right == null)
                result += root.val;
            SumOfLeftLeaves(root.left, true);
            SumOfLeftLeaves(root.right, false);
            return result;
        }
    }
}
