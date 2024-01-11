namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/description/'>Convert Sorted Array to Binary Search Tree</see>
    /// <br>Array, Divide and Conquer, Tree, Binary Search Tree, Binary Tree</br>
    /// </summary>
    internal class Problem0108
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return BuildBalancedTree(nums, 0, nums.Length-1);
        }

        private TreeNode BuildBalancedTree(int[] nums, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            var mid = (start + end) / 2;
            var node = new TreeNode
            {
                val = nums[mid],
                left = BuildBalancedTree(nums, start, mid - 1),
                right = BuildBalancedTree(nums, mid + 1, end)
            };

            return node;
        }
    }
}
