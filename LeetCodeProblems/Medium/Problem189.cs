namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/rotate-array/">Rotate Array</see>
    /// <br>Array, Math, Two Pointers</br>
    /// </summary>
    internal class Problem189
    {
        public void Rotate(int[] nums, int k)
        {
            while (k > nums.Length)
            {
                if (nums.Length <= k)
                    k -= nums.Length;
            }

            if (nums.Length == 1 || k == 0)
            {
                return;
            }

            var tempArr = nums.TakeLast(k).ToArray();

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i - k < 0)
                {
                    break;
                }
                nums[i] = nums[i - k];
            }

            for (int i = 0; i < k; i++)
            {
                nums[i] = tempArr[i];
            }
        }
    }
}
